namespace Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Extensions;

    /// <summary>An error message</summary>
    public partial class CloudError :
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.ICloudError,
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.ICloudErrorInternal
    {

        /// <summary>The error code</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Origin(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.ICloudErrorBodyInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.ICloudErrorBodyInternal)Error).Code = value ?? null; }

        /// <summary>Extra error information</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Origin(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.ICloudErrorBody[] Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.ICloudErrorBodyInternal)Error).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.ICloudErrorBodyInternal)Error).Detail = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.ICloudErrorBody _error;

        /// <summary>The error message body</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Origin(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.ICloudErrorBody Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.CloudErrorBody()); set => this._error = value; }

        /// <summary>A description of what caused the error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Origin(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.ICloudErrorBodyInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.ICloudErrorBodyInternal)Error).Message = value ?? null; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.ICloudErrorBody Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.ICloudErrorInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.CloudErrorBody()); set { {_error = value;} } }

        /// <summary>The target resource of the error message</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Origin(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.PropertyOrigin.Inlined)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.ICloudErrorBodyInternal)Error).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.ICloudErrorBodyInternal)Error).Target = value ?? null; }

        /// <summary>Creates an new <see cref="CloudError" /> instance.</summary>
        public CloudError()
        {

        }
    }
    /// An error message
    public partial interface ICloudError :
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.IJsonSerializable
    {
        /// <summary>The error code</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The error code",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get; set; }
        /// <summary>Extra error information</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Extra error information",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.ICloudErrorBody) })]
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.ICloudErrorBody[] Detail { get; set; }
        /// <summary>A description of what caused the error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A description of what caused the error",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }
        /// <summary>The target resource of the error message</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target resource of the error message",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string Target { get; set; }

    }
    /// An error message
    internal partial interface ICloudErrorInternal

    {
        /// <summary>The error code</summary>
        string Code { get; set; }
        /// <summary>Extra error information</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.ICloudErrorBody[] Detail { get; set; }
        /// <summary>The error message body</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.ICloudErrorBody Error { get; set; }
        /// <summary>A description of what caused the error</summary>
        string Message { get; set; }
        /// <summary>The target resource of the error message</summary>
        string Target { get; set; }

    }
}