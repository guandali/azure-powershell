namespace Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Extensions;

    /// <summary>Describes a DNS resolver.</summary>
    public partial class DnsResolver :
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolver,
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20.TrackedResource();

        /// <summary>Backing field for <see cref="Etag" /> property.</summary>
        private string _etag;

        /// <summary>ETag of the DNS resolver.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Origin(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.PropertyOrigin.Owned)]
        public string Etag { get => this._etag; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Origin(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20.IResourceInternal)__trackedResource).Id; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Origin(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20.ITrackedResourceInternal)__trackedResource).Location = value ; }

        /// <summary>
        /// The maximum number of inbound endpoints that can be created for the DNS resolver. This is a read-only property and any
        /// attempt to set this value will be ignored.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Origin(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.PropertyOrigin.Inlined)]
        public long? MaxNumberOfInboundEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverPropertiesInternal)Property).MaxNumberOfInboundEndpoint; }

        /// <summary>
        /// The maximum number of outbound endpoints that can be created for the DNS resolver. This is a read-only property and any
        /// attempt to set this value will be ignored.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Origin(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.PropertyOrigin.Inlined)]
        public long? MaxNumberOfOutboundEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverPropertiesInternal)Property).MaxNumberOfOutboundEndpoint; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20.IResourceInternal)__trackedResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20.IResourceInternal)__trackedResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20.IResourceInternal)__trackedResource).Type = value; }

        /// <summary>Internal Acessors for Etag</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverInternal.Etag { get => this._etag; set { {_etag = value;} } }

        /// <summary>Internal Acessors for MaxNumberOfInboundEndpoint</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverInternal.MaxNumberOfInboundEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverPropertiesInternal)Property).MaxNumberOfInboundEndpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverPropertiesInternal)Property).MaxNumberOfInboundEndpoint = value; }

        /// <summary>Internal Acessors for MaxNumberOfOutboundEndpoint</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverInternal.MaxNumberOfOutboundEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverPropertiesInternal)Property).MaxNumberOfOutboundEndpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverPropertiesInternal)Property).MaxNumberOfOutboundEndpoint = value; }

        /// <summary>Internal Acessors for NumberOfInboundEndpoint</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverInternal.NumberOfInboundEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverPropertiesInternal)Property).NumberOfInboundEndpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverPropertiesInternal)Property).NumberOfInboundEndpoint = value; }

        /// <summary>Internal Acessors for NumberOfOutboundEndpoint</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverInternal.NumberOfOutboundEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverPropertiesInternal)Property).NumberOfOutboundEndpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverPropertiesInternal)Property).NumberOfOutboundEndpoint = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverProperties Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.DnsResolverProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for ResourceGuid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverInternal.ResourceGuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverPropertiesInternal)Property).ResourceGuid; set => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverPropertiesInternal)Property).ResourceGuid = value; }

        /// <summary>Internal Acessors for State</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.DnsResolverState? Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverInternal.State { get => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverPropertiesInternal)Property).DnsResolverState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverPropertiesInternal)Property).DnsResolverState = value; }

        /// <summary>Internal Acessors for VirtualNetwork</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.ISubResource Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverInternal.VirtualNetwork { get => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverPropertiesInternal)Property).VirtualNetwork; set => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverPropertiesInternal)Property).VirtualNetwork = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Origin(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20.IResourceInternal)__trackedResource).Name; }

        /// <summary>
        /// The current number of inbound endpoints for the DNS resolver. This is a read-only property and any attempt to set this
        /// value will be ignored.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Origin(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.PropertyOrigin.Inlined)]
        public long? NumberOfInboundEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverPropertiesInternal)Property).NumberOfInboundEndpoint; }

        /// <summary>
        /// The current number of outbound endpoints for the DNS resolver. This is a read-only property and any attempt to set this
        /// value will be ignored.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Origin(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.PropertyOrigin.Inlined)]
        public long? NumberOfOutboundEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverPropertiesInternal)Property).NumberOfOutboundEndpoint; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverProperties _property;

        /// <summary>Properties of the DNS resolver.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Origin(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.DnsResolverProperties()); set => this._property = value; }

        /// <summary>
        /// The current provisioning state of the DNS resolver. This is a read-only property and any attempt to set this value will
        /// be ignored.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Origin(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverPropertiesInternal)Property).ProvisioningState; }

        /// <summary>The resourceGuid property of the DNS resolver resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Origin(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.PropertyOrigin.Inlined)]
        public string ResourceGuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverPropertiesInternal)Property).ResourceGuid; }

        /// <summary>
        /// The current status of the DNS resolver. This is a read-only property and any attempt to set this value will be ignored.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Origin(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.DnsResolverState? State { get => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverPropertiesInternal)Property).DnsResolverState; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Origin(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Origin(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20.IResourceInternal)__trackedResource).Type; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Origin(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.PropertyOrigin.Inlined)]
        public string VirtualNetworkId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverPropertiesInternal)Property).VirtualNetworkId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverPropertiesInternal)Property).VirtualNetworkId = value ?? null; }

        /// <summary>Creates an new <see cref="DnsResolver" /> instance.</summary>
        public DnsResolver()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// Describes a DNS resolver.
    public partial interface IDnsResolver :
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20.ITrackedResource
    {
        /// <summary>ETag of the DNS resolver.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"ETag of the DNS resolver.",
        SerializedName = @"etag",
        PossibleTypes = new [] { typeof(string) })]
        string Etag { get;  }
        /// <summary>
        /// The maximum number of inbound endpoints that can be created for the DNS resolver. This is a read-only property and any
        /// attempt to set this value will be ignored.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The maximum number of inbound endpoints that can be created for the DNS resolver. This is a read-only property and any attempt to set this value will be ignored.",
        SerializedName = @"maxNumberOfInboundEndpoints",
        PossibleTypes = new [] { typeof(long) })]
        long? MaxNumberOfInboundEndpoint { get;  }
        /// <summary>
        /// The maximum number of outbound endpoints that can be created for the DNS resolver. This is a read-only property and any
        /// attempt to set this value will be ignored.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The maximum number of outbound endpoints that can be created for the DNS resolver. This is a read-only property and any attempt to set this value will be ignored.",
        SerializedName = @"maxNumberOfOutboundEndpoints",
        PossibleTypes = new [] { typeof(long) })]
        long? MaxNumberOfOutboundEndpoint { get;  }
        /// <summary>
        /// The current number of inbound endpoints for the DNS resolver. This is a read-only property and any attempt to set this
        /// value will be ignored.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The current number of inbound endpoints for the DNS resolver. This is a read-only property and any attempt to set this value will be ignored.",
        SerializedName = @"numberOfInboundEndpoints",
        PossibleTypes = new [] { typeof(long) })]
        long? NumberOfInboundEndpoint { get;  }
        /// <summary>
        /// The current number of outbound endpoints for the DNS resolver. This is a read-only property and any attempt to set this
        /// value will be ignored.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The current number of outbound endpoints for the DNS resolver. This is a read-only property and any attempt to set this value will be ignored.",
        SerializedName = @"numberOfOutboundEndpoints",
        PossibleTypes = new [] { typeof(long) })]
        long? NumberOfOutboundEndpoint { get;  }
        /// <summary>
        /// The current provisioning state of the DNS resolver. This is a read-only property and any attempt to set this value will
        /// be ignored.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The current provisioning state of the DNS resolver. This is a read-only property and any attempt to set this value will be ignored.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>The resourceGuid property of the DNS resolver resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resourceGuid property of the DNS resolver resource.",
        SerializedName = @"resourceGuid",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGuid { get;  }
        /// <summary>
        /// The current status of the DNS resolver. This is a read-only property and any attempt to set this value will be ignored.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The current status of the DNS resolver. This is a read-only property and any attempt to set this value will be ignored.",
        SerializedName = @"dnsResolverState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.DnsResolverState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.DnsResolverState? State { get;  }
        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string VirtualNetworkId { get; set; }

    }
    /// Describes a DNS resolver.
    internal partial interface IDnsResolverInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20.ITrackedResourceInternal
    {
        /// <summary>ETag of the DNS resolver.</summary>
        string Etag { get; set; }
        /// <summary>
        /// The maximum number of inbound endpoints that can be created for the DNS resolver. This is a read-only property and any
        /// attempt to set this value will be ignored.
        /// </summary>
        long? MaxNumberOfInboundEndpoint { get; set; }
        /// <summary>
        /// The maximum number of outbound endpoints that can be created for the DNS resolver. This is a read-only property and any
        /// attempt to set this value will be ignored.
        /// </summary>
        long? MaxNumberOfOutboundEndpoint { get; set; }
        /// <summary>
        /// The current number of inbound endpoints for the DNS resolver. This is a read-only property and any attempt to set this
        /// value will be ignored.
        /// </summary>
        long? NumberOfInboundEndpoint { get; set; }
        /// <summary>
        /// The current number of outbound endpoints for the DNS resolver. This is a read-only property and any attempt to set this
        /// value will be ignored.
        /// </summary>
        long? NumberOfOutboundEndpoint { get; set; }
        /// <summary>Properties of the DNS resolver.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IDnsResolverProperties Property { get; set; }
        /// <summary>
        /// The current provisioning state of the DNS resolver. This is a read-only property and any attempt to set this value will
        /// be ignored.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>The resourceGuid property of the DNS resolver resource.</summary>
        string ResourceGuid { get; set; }
        /// <summary>
        /// The current status of the DNS resolver. This is a read-only property and any attempt to set this value will be ignored.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.DnsResolverState? State { get; set; }
        /// <summary>The reference to the virtual network. This cannot be changed after creation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.ISubResource VirtualNetwork { get; set; }
        /// <summary>Resource ID.</summary>
        string VirtualNetworkId { get; set; }

    }
}