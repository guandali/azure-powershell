namespace Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Extensions;

    /// <summary>Represents the properties of an inbound endpoint for a DNS resolver.</summary>
    public partial class InboundEndpointProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IInboundEndpointProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IInboundEndpointPropertiesInternal
    {

        /// <summary>Backing field for <see cref="IPConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IIPConfiguration[] _iPConfiguration;

        /// <summary>IP configurations for the inbound endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Origin(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IIPConfiguration[] IPConfiguration { get => this._iPConfiguration; set => this._iPConfiguration = value; }

        /// <summary>Backing field for <see cref="Metadata" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IInboundEndpointPropertiesMetadata _metadata;

        /// <summary>Metadata attached to the inbound endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Origin(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IInboundEndpointPropertiesMetadata Metadata { get => (this._metadata = this._metadata ?? new Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.InboundEndpointPropertiesMetadata()); set => this._metadata = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IInboundEndpointPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for ResourceGuid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IInboundEndpointPropertiesInternal.ResourceGuid { get => this._resourceGuid; set { {_resourceGuid = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.ProvisioningState? _provisioningState;

        /// <summary>
        /// The current provisioning state of the inbound endpoint. This is a read-only property and any attempt to set this value
        /// will be ignored.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Origin(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="ResourceGuid" /> property.</summary>
        private string _resourceGuid;

        /// <summary>The resourceGuid property of the inbound endpoint resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Origin(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.PropertyOrigin.Owned)]
        public string ResourceGuid { get => this._resourceGuid; }

        /// <summary>Creates an new <see cref="InboundEndpointProperties" /> instance.</summary>
        public InboundEndpointProperties()
        {

        }
    }
    /// Represents the properties of an inbound endpoint for a DNS resolver.
    public partial interface IInboundEndpointProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.IJsonSerializable
    {
        /// <summary>IP configurations for the inbound endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"IP configurations for the inbound endpoint.",
        SerializedName = @"ipConfigurations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IIPConfiguration) })]
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IIPConfiguration[] IPConfiguration { get; set; }
        /// <summary>Metadata attached to the inbound endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Metadata attached to the inbound endpoint.",
        SerializedName = @"metadata",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IInboundEndpointPropertiesMetadata) })]
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IInboundEndpointPropertiesMetadata Metadata { get; set; }
        /// <summary>
        /// The current provisioning state of the inbound endpoint. This is a read-only property and any attempt to set this value
        /// will be ignored.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The current provisioning state of the inbound endpoint. This is a read-only property and any attempt to set this value will be ignored.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>The resourceGuid property of the inbound endpoint resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resourceGuid property of the inbound endpoint resource.",
        SerializedName = @"resourceGuid",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGuid { get;  }

    }
    /// Represents the properties of an inbound endpoint for a DNS resolver.
    internal partial interface IInboundEndpointPropertiesInternal

    {
        /// <summary>IP configurations for the inbound endpoint.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IIPConfiguration[] IPConfiguration { get; set; }
        /// <summary>Metadata attached to the inbound endpoint.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IInboundEndpointPropertiesMetadata Metadata { get; set; }
        /// <summary>
        /// The current provisioning state of the inbound endpoint. This is a read-only property and any attempt to set this value
        /// will be ignored.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>The resourceGuid property of the inbound endpoint resource.</summary>
        string ResourceGuid { get; set; }

    }
}