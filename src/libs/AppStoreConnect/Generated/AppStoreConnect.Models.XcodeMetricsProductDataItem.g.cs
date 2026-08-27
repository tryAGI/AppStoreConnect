
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class XcodeMetricsProductDataItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        public string? Platform { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metricCategories")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorie>? MetricCategories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeMetricsProductDataItem" /> class.
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="metricCategories"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public XcodeMetricsProductDataItem(
            string? platform,
            global::System.Collections.Generic.IList<global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorie>? metricCategories)
        {
            this.Platform = platform;
            this.MetricCategories = metricCategories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeMetricsProductDataItem" /> class.
        /// </summary>
        public XcodeMetricsProductDataItem()
        {
        }

    }
}