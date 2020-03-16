﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Management.IotHub
{
    using System.Collections.Generic;
    using System.Management.Automation;
    using Microsoft.Azure.Commands.Management.IotHub.Common;
    using Microsoft.Azure.Commands.Management.IotHub.Models;
    using Microsoft.Azure.Devices;
    using Microsoft.Azure.Devices.Shared;
    using Microsoft.Azure.Management.IotHub;
    using Microsoft.Azure.Management.IotHub.Models;
    using Microsoft.WindowsAzure.Commands.Utilities.Common;
    using Newtonsoft.Json;
    using ResourceManager.Common.ArgumentCompleters;

    [Cmdlet("Set", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "IotHubDistributedTracing", DefaultParameterSetName = ResourceParameterSet, SupportsShouldProcess = true)]
    [Alias("Set-" + ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "IotHubTracing")]
    [OutputType(typeof(PSDeviceTracing))]
    public class SetAzIotHubDistributedTracing : IotHubBaseCmdlet
    {
        private const string ResourceIdParameterSet = "ResourceIdSet";
        private const string ResourceParameterSet = "ResourceSet";
        private const string InputObjectParameterSet = "InputObjectSet";

        [Parameter(Position = 0, Mandatory = true, ParameterSetName = InputObjectParameterSet, ValueFromPipeline = true, HelpMessage = "IotHub object")]
        [ValidateNotNullOrEmpty]
        public PSIotHub InputObject { get; set; }

        [Parameter(Position = 0, Mandatory = true, ParameterSetName = ResourceParameterSet, HelpMessage = "Name of the Resource Group")]
        [ValidateNotNullOrEmpty]
        [ResourceGroupCompleter]
        public string ResourceGroupName { get; set; }

        [Parameter(Position = 0, Mandatory = true, ParameterSetName = ResourceIdParameterSet, ValueFromPipelineByPropertyName = true, HelpMessage = "IotHub Resource Id")]
        [ValidateNotNullOrEmpty]
        [ResourceIdCompleter("Microsoft.Devices/IotHubs")]
        public string ResourceId { get; set; }

        [Parameter(Position = 1, Mandatory = true, ParameterSetName = ResourceParameterSet, HelpMessage = "Name of the Iot Hub")]
        [ValidateNotNullOrEmpty]
        public string IotHubName { get; set; }

        [Parameter(Position = 1, Mandatory = true, ParameterSetName = InputObjectParameterSet, HelpMessage = "Target Device Id.")]
        [Parameter(Position = 1, Mandatory = true, ParameterSetName = ResourceIdParameterSet, HelpMessage = "Target Device Id.")]
        [Parameter(Position = 2, Mandatory = true, ParameterSetName = ResourceParameterSet, HelpMessage = "Target Device Id.")]
        [ValidateNotNullOrEmpty]
        public string DeviceId { get; set; }

        [Parameter(Position = 2, Mandatory = true, ParameterSetName = InputObjectParameterSet, HelpMessage = "Turns sampling for distributed tracing enable and disable.")]
        [Parameter(Position = 2, Mandatory = true, ParameterSetName = ResourceIdParameterSet, HelpMessage = "Turns sampling for distributed tracing enable and disable.")]
        [Parameter(Position = 3, Mandatory = true, ParameterSetName = ResourceParameterSet, HelpMessage = "Turns sampling for distributed tracing enable and disable.")]
        [Alias("Mode")]
        public PSDistributedTracingSamplingMode SamplingMode { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = InputObjectParameterSet, HelpMessage = "Controls the amount of messages sampled for adding trace context. This value is a percentage. Only values from 0 to 100 (inclusive) are permitted.")]
        [Parameter(Mandatory = false, ParameterSetName = ResourceIdParameterSet, HelpMessage = "Controls the amount of messages sampled for adding trace context. This value is a percentage. Only values from 0 to 100 (inclusive) are permitted.")]
        [Parameter(Mandatory = false, ParameterSetName = ResourceParameterSet, HelpMessage = "Controls the amount of messages sampled for adding trace context. This value is a percentage. Only values from 0 to 100 (inclusive) are permitted.")]
        [ValidateRange(0,100)]
        [Alias("Rate")]
        public int SamplingRate { get; set; }

        public override void ExecuteCmdlet()
        {
            if (ShouldProcess(this.DeviceId, Properties.Resources.SetIotHubDistributedTracing))
            {
                IotHubDescription iotHubDescription;
                if (ParameterSetName.Equals(InputObjectParameterSet))
                {
                    this.ResourceGroupName = this.InputObject.Resourcegroup;
                    this.IotHubName = this.InputObject.Name;
                    iotHubDescription = IotHubUtils.ConvertObject<PSIotHub, IotHubDescription>(this.InputObject);
                }
                else
                {
                    if (ParameterSetName.Equals(ResourceIdParameterSet))
                    {
                        this.ResourceGroupName = IotHubUtils.GetResourceGroupName(this.ResourceId);
                        this.IotHubName = IotHubUtils.GetIotHubName(this.ResourceId);
                    }

                    iotHubDescription = this.IotHubClient.IotHubResource.Get(this.ResourceGroupName, this.IotHubName);
                }

                IEnumerable<SharedAccessSignatureAuthorizationRule> authPolicies = this.IotHubClient.IotHubResource.ListKeys(this.ResourceGroupName, this.IotHubName);
                SharedAccessSignatureAuthorizationRule policy = IotHubUtils.GetPolicy(authPolicies, PSAccessRights.RegistryWrite);
                PSIotHubConnectionString psIotHubConnectionString = IotHubUtils.ToPSIotHubConnectionString(policy, iotHubDescription.Properties.HostName);
                RegistryManager registryManager = RegistryManager.CreateFromConnectionString(psIotHubConnectionString.PrimaryConnectionString);

                PSDistributedTracing psDistributedTracing = new PSDistributedTracing();
                Twin deviceTwin = registryManager.GetTwinAsync(this.DeviceId).GetAwaiter().GetResult();

                IotHubDataPlaneUtils.ValidateDeviceTracing(this.DeviceId, iotHubDescription.Sku.Tier.Value.ToString(), iotHubDescription.Location, deviceTwin.Capabilities.IotEdge);
                
                if (deviceTwin.Properties.Desired.Contains(IotHubDataPlaneUtils.TracingProperty))
                {
                    psDistributedTracing = JsonConvert.DeserializeObject<PSDistributedTracing>(deviceTwin.Properties.Desired[IotHubDataPlaneUtils.TracingProperty].ToString());
                }

                psDistributedTracing.SamplingMode = this.SamplingMode;

                if (this.SamplingMode.Equals(PSDistributedTracingSamplingMode.Enabled))
                {
                    if (this.IsParameterBound(c => c.SamplingRate))
                    {
                        psDistributedTracing.SamplingRate = this.SamplingRate;
                    }
                }

                deviceTwin.Properties.Desired[IotHubDataPlaneUtils.TracingProperty] = psDistributedTracing;

                deviceTwin = registryManager.UpdateTwinAsync(this.DeviceId, deviceTwin, deviceTwin.ETag).GetAwaiter().GetResult();
                
                this.WriteObject(IotHubDataPlaneUtils.GetDeviceTracing(this.DeviceId, deviceTwin));
            }
        }
    }
}
