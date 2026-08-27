
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnalyticsReportRequestAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AnalyticsReportRequestAttributesAccessTypeJsonConverter))]
        public global::AppStoreConnect.AnalyticsReportRequestAttributesAccessType? AccessType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stoppedDueToInactivity")]
        public bool? StoppedDueToInactivity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsReportRequestAttributes" /> class.
        /// </summary>
        /// <param name="accessType"></param>
        /// <param name="stoppedDueToInactivity"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsReportRequestAttributes(
            global::AppStoreConnect.AnalyticsReportRequestAttributesAccessType? accessType,
            bool? stoppedDueToInactivity)
        {
            this.AccessType = accessType;
            this.StoppedDueToInactivity = stoppedDueToInactivity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsReportRequestAttributes" /> class.
        /// </summary>
        public AnalyticsReportRequestAttributes()
        {
        }

    }
}