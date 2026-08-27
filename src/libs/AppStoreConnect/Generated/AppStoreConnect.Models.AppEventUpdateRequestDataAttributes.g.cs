
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppEventUpdateRequestDataAttributes
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppEventUpdateRequestDataAttributesBadgeJsonConverter))]
        public global::AppStoreConnect.AppEventUpdateRequestDataAttributesBadge? Badge { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppEventUpdateRequestDataAttributesPriorityJsonConverter))]
        public global::AppStoreConnect.AppEventUpdateRequestDataAttributesPriority? Priority { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppEventUpdateRequestDataAttributesPurposeJsonConverter))]
        public global::AppStoreConnect.AppEventUpdateRequestDataAttributesPurpose? Purpose { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("territorySchedules")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventUpdateRequestDataAttributesTerritorySchedule>? TerritorySchedules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="referenceName"></param>
        /// <param name="badge"></param>
        /// <param name="deepLink"></param>
        /// <param name="purchaseRequirement"></param>
        /// <param name="primaryLocale"></param>
        /// <param name="priority"></param>
        /// <param name="purpose"></param>
        /// <param name="territorySchedules"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppEventUpdateRequestDataAttributes(
            string? referenceName,
            global::AppStoreConnect.AppEventUpdateRequestDataAttributesBadge? badge,
            string? deepLink,
            string? purchaseRequirement,
            string? primaryLocale,
            global::AppStoreConnect.AppEventUpdateRequestDataAttributesPriority? priority,
            global::AppStoreConnect.AppEventUpdateRequestDataAttributesPurpose? purpose,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventUpdateRequestDataAttributesTerritorySchedule>? territorySchedules)
        {
            this.ReferenceName = referenceName;
            this.Badge = badge;
            this.DeepLink = deepLink;
            this.PurchaseRequirement = purchaseRequirement;
            this.PrimaryLocale = primaryLocale;
            this.Priority = priority;
            this.Purpose = purpose;
            this.TerritorySchedules = territorySchedules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventUpdateRequestDataAttributes" /> class.
        /// </summary>
        public AppEventUpdateRequestDataAttributes()
        {
        }

    }
}