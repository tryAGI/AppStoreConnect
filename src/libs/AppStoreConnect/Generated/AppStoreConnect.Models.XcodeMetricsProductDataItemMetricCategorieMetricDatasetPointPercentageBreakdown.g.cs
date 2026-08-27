
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class XcodeMetricsProductDataItemMetricCategorieMetricDatasetPointPercentageBreakdown
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subSystemLabel")]
        public string? SubSystemLabel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeMetricsProductDataItemMetricCategorieMetricDatasetPointPercentageBreakdown" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="subSystemLabel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public XcodeMetricsProductDataItemMetricCategorieMetricDatasetPointPercentageBreakdown(
            double? value,
            string? subSystemLabel)
        {
            this.Value = value;
            this.SubSystemLabel = subSystemLabel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeMetricsProductDataItemMetricCategorieMetricDatasetPointPercentageBreakdown" /> class.
        /// </summary>
        public XcodeMetricsProductDataItemMetricCategorieMetricDatasetPointPercentageBreakdown()
        {
        }

    }
}