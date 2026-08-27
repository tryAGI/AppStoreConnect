
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class XcodeMetrics
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insights")]
        public global::AppStoreConnect.XcodeMetricsInsights? Insights { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productData")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.XcodeMetricsProductDataItem>? ProductData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeMetrics" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="insights"></param>
        /// <param name="productData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public XcodeMetrics(
            string? version,
            global::AppStoreConnect.XcodeMetricsInsights? insights,
            global::System.Collections.Generic.IList<global::AppStoreConnect.XcodeMetricsProductDataItem>? productData)
        {
            this.Version = version;
            this.Insights = insights;
            this.ProductData = productData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeMetrics" /> class.
        /// </summary>
        public XcodeMetrics()
        {
        }

    }
}