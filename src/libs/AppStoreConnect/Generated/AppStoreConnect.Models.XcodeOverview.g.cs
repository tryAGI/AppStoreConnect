
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class XcodeOverview
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appMetadata")]
        public global::AppStoreConnect.XcodeOverviewAppMetadata? AppMetadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insights")]
        public global::AppStoreConnect.XcodeOverviewInsights? Insights { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.XcodeOverviewCategorie>? Categories { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signatures")]
        public global::AppStoreConnect.XcodeOverviewSignatures? Signatures { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("telemetryIdentifier")]
        public string? TelemetryIdentifier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeOverview" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="appMetadata"></param>
        /// <param name="insights"></param>
        /// <param name="categories"></param>
        /// <param name="signatures"></param>
        /// <param name="telemetryIdentifier"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public XcodeOverview(
            string? version,
            global::AppStoreConnect.XcodeOverviewAppMetadata? appMetadata,
            global::AppStoreConnect.XcodeOverviewInsights? insights,
            global::System.Collections.Generic.IList<global::AppStoreConnect.XcodeOverviewCategorie>? categories,
            global::AppStoreConnect.XcodeOverviewSignatures? signatures,
            string? telemetryIdentifier)
        {
            this.Version = version;
            this.AppMetadata = appMetadata;
            this.Insights = insights;
            this.Categories = categories;
            this.Signatures = signatures;
            this.TelemetryIdentifier = telemetryIdentifier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeOverview" /> class.
        /// </summary>
        public XcodeOverview()
        {
        }

    }
}