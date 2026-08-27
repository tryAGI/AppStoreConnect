
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppEventAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceName")]
        public string? ReferenceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("badge")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppEventAttributesBadgeJsonConverter))]
        public global::AppStoreConnect.AppEventAttributesBadge? Badge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppEventAttributesEventStateJsonConverter))]
        public global::AppStoreConnect.AppEventAttributesEventState? EventState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deepLink")]
        public string? DeepLink { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchaseRequirement")]
        public string? PurchaseRequirement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primaryLocale")]
        public string? PrimaryLocale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppEventAttributesPriorityJsonConverter))]
        public global::AppStoreConnect.AppEventAttributesPriority? Priority { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppEventAttributesPurposeJsonConverter))]
        public global::AppStoreConnect.AppEventAttributesPurpose? Purpose { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("territorySchedules")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventAttributesTerritorySchedule>? TerritorySchedules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archivedTerritorySchedules")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventAttributesArchivedTerritorySchedule>? ArchivedTerritorySchedules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventAttributes" /> class.
        /// </summary>
        /// <param name="referenceName"></param>
        /// <param name="badge"></param>
        /// <param name="eventState"></param>
        /// <param name="deepLink"></param>
        /// <param name="purchaseRequirement"></param>
        /// <param name="primaryLocale"></param>
        /// <param name="priority"></param>
        /// <param name="purpose"></param>
        /// <param name="territorySchedules"></param>
        /// <param name="archivedTerritorySchedules"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppEventAttributes(
            string? referenceName,
            global::AppStoreConnect.AppEventAttributesBadge? badge,
            global::AppStoreConnect.AppEventAttributesEventState? eventState,
            string? deepLink,
            string? purchaseRequirement,
            string? primaryLocale,
            global::AppStoreConnect.AppEventAttributesPriority? priority,
            global::AppStoreConnect.AppEventAttributesPurpose? purpose,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventAttributesTerritorySchedule>? territorySchedules,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventAttributesArchivedTerritorySchedule>? archivedTerritorySchedules)
        {
            this.ReferenceName = referenceName;
            this.Badge = badge;
            this.EventState = eventState;
            this.DeepLink = deepLink;
            this.PurchaseRequirement = purchaseRequirement;
            this.PrimaryLocale = primaryLocale;
            this.Priority = priority;
            this.Purpose = purpose;
            this.TerritorySchedules = territorySchedules;
            this.ArchivedTerritorySchedules = archivedTerritorySchedules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventAttributes" /> class.
        /// </summary>
        public AppEventAttributes()
        {
        }

    }
}