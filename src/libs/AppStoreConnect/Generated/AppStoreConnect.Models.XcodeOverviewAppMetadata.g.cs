
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class XcodeOverviewAppMetadata
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bundleId")]
        public string? BundleId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appId")]
        public string? AppId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latestVersion")]
        public string? LatestVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        public string? Platform { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeOverviewAppMetadata" /> class.
        /// </summary>
        /// <param name="bundleId"></param>
        /// <param name="appId"></param>
        /// <param name="latestVersion"></param>
        /// <param name="platform"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public XcodeOverviewAppMetadata(
            string? bundleId,
            string? appId,
            string? latestVersion,
            string? platform)
        {
            this.BundleId = bundleId;
            this.AppId = appId;
            this.LatestVersion = latestVersion;
            this.Platform = platform;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeOverviewAppMetadata" /> class.
        /// </summary>
        public XcodeOverviewAppMetadata()
        {
        }

    }
}