
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionPromotionalOfferAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SubscriptionOfferDurationJsonConverter))]
        public global::AppStoreConnect.SubscriptionOfferDuration? Duration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numberOfPeriods")]
        public int? NumberOfPeriods { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offerCode")]
        public string? OfferCode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offerMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SubscriptionOfferModeJsonConverter))]
        public global::AppStoreConnect.SubscriptionOfferMode? OfferMode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetSubscriptionPlanType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SubscriptionPlanTypeJsonConverter))]
        public global::AppStoreConnect.SubscriptionPlanType? TargetSubscriptionPlanType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPromotionalOfferAttributes" /> class.
        /// </summary>
        /// <param name="duration"></param>
        /// <param name="name"></param>
        /// <param name="numberOfPeriods"></param>
        /// <param name="offerCode"></param>
        /// <param name="offerMode"></param>
        /// <param name="targetSubscriptionPlanType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionPromotionalOfferAttributes(
            global::AppStoreConnect.SubscriptionOfferDuration? duration,
            string? name,
            int? numberOfPeriods,
            string? offerCode,
            global::AppStoreConnect.SubscriptionOfferMode? offerMode,
            global::AppStoreConnect.SubscriptionPlanType? targetSubscriptionPlanType)
        {
            this.Duration = duration;
            this.Name = name;
            this.NumberOfPeriods = numberOfPeriods;
            this.OfferCode = offerCode;
            this.OfferMode = offerMode;
            this.TargetSubscriptionPlanType = targetSubscriptionPlanType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPromotionalOfferAttributes" /> class.
        /// </summary>
        public SubscriptionPromotionalOfferAttributes()
        {
        }

    }
}