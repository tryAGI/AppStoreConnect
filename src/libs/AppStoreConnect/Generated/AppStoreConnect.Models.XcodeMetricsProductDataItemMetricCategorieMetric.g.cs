
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class XcodeMetricsProductDataItemMetricCategorieMetric
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        public string? Identifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("goalKeys")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricGoalKey>? GoalKeys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        public global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricUnit? Unit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasets")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricDataset>? Datasets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeMetricsProductDataItemMetricCategorieMetric" /> class.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="goalKeys"></param>
        /// <param name="unit"></param>
        /// <param name="datasets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public XcodeMetricsProductDataItemMetricCategorieMetric(
            string? identifier,
            global::System.Collections.Generic.IList<global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricGoalKey>? goalKeys,
            global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricUnit? unit,
            global::System.Collections.Generic.IList<global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricDataset>? datasets)
        {
            this.Identifier = identifier;
            this.GoalKeys = goalKeys;
            this.Unit = unit;
            this.Datasets = datasets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeMetricsProductDataItemMetricCategorieMetric" /> class.
        /// </summary>
        public XcodeMetricsProductDataItemMetricCategorieMetric()
        {
        }

    }
}