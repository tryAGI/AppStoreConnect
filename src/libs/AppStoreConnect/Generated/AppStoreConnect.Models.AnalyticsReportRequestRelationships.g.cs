
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnalyticsReportRequestRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reports")]
        public global::AppStoreConnect.AnalyticsReportRequestRelationshipsReports? Reports { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsReportRequestRelationships" /> class.
        /// </summary>
        /// <param name="reports"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsReportRequestRelationships(
            global::AppStoreConnect.AnalyticsReportRequestRelationshipsReports? reports)
        {
            this.Reports = reports;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsReportRequestRelationships" /> class.
        /// </summary>
        public AnalyticsReportRequestRelationships()
        {
        }

    }
}