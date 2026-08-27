
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionPromotionalOfferCreateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SubscriptionOfferDurationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.SubscriptionOfferDuration Duration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numberOfPeriods")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumberOfPeriods { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offerCode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OfferCode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offerMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SubscriptionOfferModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.SubscriptionOfferMode OfferMode { get; set; }

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
        /// Initializes a new instance of the <see cref="SubscriptionPromotionalOfferCreateRequestDataAttributes" /> class.
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
        public SubscriptionPromotionalOfferCreateRequestDataAttributes(
            global::AppStoreConnect.SubscriptionOfferDuration duration,
            string name,
            int numberOfPeriods,
            string offerCode,
            global::AppStoreConnect.SubscriptionOfferMode offerMode,
            global::AppStoreConnect.SubscriptionPlanType? targetSubscriptionPlanType)
        {
            this.Duration = duration;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.NumberOfPeriods = numberOfPeriods;
            this.OfferCode = offerCode ?? throw new global::System.ArgumentNullException(nameof(offerCode));
            this.OfferMode = offerMode;
            this.TargetSubscriptionPlanType = targetSubscriptionPlanType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPromotionalOfferCreateRequestDataAttributes" /> class.
        /// </summary>
        public SubscriptionPromotionalOfferCreateRequestDataAttributes()
        {
        }

    }
}