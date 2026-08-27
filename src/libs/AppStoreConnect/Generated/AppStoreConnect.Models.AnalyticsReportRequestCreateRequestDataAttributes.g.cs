
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnalyticsReportRequestCreateRequestDataAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AnalyticsReportRequestCreateRequestDataAttributesAccessTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AnalyticsReportRequestCreateRequestDataAttributesAccessType AccessType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsReportRequestCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="accessType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsReportRequestCreateRequestDataAttributes(
            global::AppStoreConnect.AnalyticsReportRequestCreateRequestDataAttributesAccessType accessType)
        {
            this.AccessType = accessType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsReportRequestCreateRequestDataAttributes" /> class.
        /// </summary>
        public AnalyticsReportRequestCreateRequestDataAttributes()
        {
        }

    }
}