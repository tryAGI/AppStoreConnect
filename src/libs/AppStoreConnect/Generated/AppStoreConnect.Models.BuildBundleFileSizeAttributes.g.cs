
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuildBundleFileSizeAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceModel")]
        public string? DeviceModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("osVersion")]
        public string? OsVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloadBytes")]
        public long? DownloadBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installBytes")]
        public long? InstallBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildBundleFileSizeAttributes" /> class.
        /// </summary>
        /// <param name="deviceModel"></param>
        /// <param name="osVersion"></param>
        /// <param name="downloadBytes"></param>
        /// <param name="installBytes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuildBundleFileSizeAttributes(
            string? deviceModel,
            string? osVersion,
            long? downloadBytes,
            long? installBytes)
        {
            this.DeviceModel = deviceModel;
            this.OsVersion = osVersion;
            this.DownloadBytes = downloadBytes;
            this.InstallBytes = installBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildBundleFileSizeAttributes" /> class.
        /// </summary>
        public BuildBundleFileSizeAttributes()
        {
        }

    }
}