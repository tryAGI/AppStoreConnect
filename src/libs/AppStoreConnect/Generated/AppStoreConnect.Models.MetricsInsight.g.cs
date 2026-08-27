
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MetricsInsight
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metricCategory")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.MetricCategoryJsonConverter))]
        public global::AppStoreConnect.MetricCategory? MetricCategory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latestVersion")]
        public string? LatestVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        public string? Metric { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summaryString")]
        public string? SummaryString { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceVersions")]
        public string? ReferenceVersions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxLatestVersionValue")]
        public double? MaxLatestVersionValue { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subSystemLabel")]
        public string? SubSystemLabel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highImpact")]
        public bool? HighImpact { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("populations")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.MetricsInsightPopulation>? Populations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsInsight" /> class.
        /// </summary>
        /// <param name="metricCategory"></param>
        /// <param name="latestVersion"></param>
        /// <param name="metric"></param>
        /// <param name="summaryString"></param>
        /// <param name="referenceVersions"></param>
        /// <param name="maxLatestVersionValue"></param>
        /// <param name="subSystemLabel"></param>
        /// <param name="highImpact"></param>
        /// <param name="populations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetricsInsight(
            global::AppStoreConnect.MetricCategory? metricCategory,
            string? latestVersion,
            string? metric,
            string? summaryString,
            string? referenceVersions,
            double? maxLatestVersionValue,
            string? subSystemLabel,
            bool? highImpact,
            global::System.Collections.Generic.IList<global::AppStoreConnect.MetricsInsightPopulation>? populations)
        {
            this.MetricCategory = metricCategory;
            this.LatestVersion = latestVersion;
            this.Metric = metric;
            this.SummaryString = summaryString;
            this.ReferenceVersions = referenceVersions;
            this.MaxLatestVersionValue = maxLatestVersionValue;
            this.SubSystemLabel = subSystemLabel;
            this.HighImpact = highImpact;
            this.Populations = populations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsInsight" /> class.
        /// </summary>
        public MetricsInsight()
        {
        }

    }
}