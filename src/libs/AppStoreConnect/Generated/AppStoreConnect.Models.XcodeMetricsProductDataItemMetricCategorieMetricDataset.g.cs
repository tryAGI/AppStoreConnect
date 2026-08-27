
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class XcodeMetricsProductDataItemMetricCategorieMetricDataset
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filterCriteria")]
        public global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricDatasetFilterCriteria? FilterCriteria { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("points")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricDatasetPoint>? Points { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recommendedMetricGoal")]
        public global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricDatasetRecommendedMetricGoal? RecommendedMetricGoal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeMetricsProductDataItemMetricCategorieMetricDataset" /> class.
        /// </summary>
        /// <param name="filterCriteria"></param>
        /// <param name="points"></param>
        /// <param name="recommendedMetricGoal"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public XcodeMetricsProductDataItemMetricCategorieMetricDataset(
            global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricDatasetFilterCriteria? filterCriteria,
            global::System.Collections.Generic.IList<global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricDatasetPoint>? points,
            global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricDatasetRecommendedMetricGoal? recommendedMetricGoal)
        {
            this.FilterCriteria = filterCriteria;
            this.Points = points;
            this.RecommendedMetricGoal = recommendedMetricGoal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeMetricsProductDataItemMetricCategorieMetricDataset" /> class.
        /// </summary>
        public XcodeMetricsProductDataItemMetricCategorieMetricDataset()
        {
        }

    }
}