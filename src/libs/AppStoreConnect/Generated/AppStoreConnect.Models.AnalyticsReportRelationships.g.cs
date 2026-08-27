
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnalyticsReportRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instances")]
        public global::AppStoreConnect.AnalyticsReportRelationshipsInstances? Instances { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsReportRelationships" /> class.
        /// </summary>
        /// <param name="instances"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsReportRelationships(
            global::AppStoreConnect.AnalyticsReportRelationshipsInstances? instances)
        {
            this.Instances = instances;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsReportRelationships" /> class.
        /// </summary>
        public AnalyticsReportRelationships()
        {
        }

    }
}