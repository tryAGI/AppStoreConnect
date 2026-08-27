
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnalyticsReportInstanceAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("granularity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AnalyticsReportInstanceAttributesGranularityJsonConverter))]
        public global::AppStoreConnect.AnalyticsReportInstanceAttributesGranularity? Granularity { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processingDate")]
        public global::System.DateTime? ProcessingDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsReportInstanceAttributes" /> class.
        /// </summary>
        /// <param name="granularity"></param>
        /// <param name="processingDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsReportInstanceAttributes(
            global::AppStoreConnect.AnalyticsReportInstanceAttributesGranularity? granularity,
            global::System.DateTime? processingDate)
        {
            this.Granularity = granularity;
            this.ProcessingDate = processingDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsReportInstanceAttributes" /> class.
        /// </summary>
        public AnalyticsReportInstanceAttributes()
        {
        }

    }
}