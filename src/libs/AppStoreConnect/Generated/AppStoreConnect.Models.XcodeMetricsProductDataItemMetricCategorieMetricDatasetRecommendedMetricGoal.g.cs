
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class XcodeMetricsProductDataItemMetricCategorieMetricDatasetRecommendedMetricGoal
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeMetricsProductDataItemMetricCategorieMetricDatasetRecommendedMetricGoal" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="detail"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public XcodeMetricsProductDataItemMetricCategorieMetricDatasetRecommendedMetricGoal(
            double? value,
            string? detail)
        {
            this.Value = value;
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeMetricsProductDataItemMetricCategorieMetricDatasetRecommendedMetricGoal" /> class.
        /// </summary>
        public XcodeMetricsProductDataItemMetricCategorieMetricDatasetRecommendedMetricGoal()
        {
        }

    }
}