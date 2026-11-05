
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RetentionOfferCreateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReferenceName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OfferId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("offerMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SubscriptionOfferModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.SubscriptionOfferMode OfferMode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("periodCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PeriodCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customerEligibilityPaidSubscriptionDurationInMonths")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CustomerEligibilityPaidSubscriptionDurationInMonths { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customerEligibilityWaitBetweenOffersInMonths")]
        public int? CustomerEligibilityWaitBetweenOffersInMonths { get; set; }

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
        /// Initializes a new instance of the <see cref="RetentionOfferCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="referenceName"></param>
        /// <param name="offerId"></param>
        /// <param name="duration"></param>
        /// <param name="offerMode"></param>
        /// <param name="periodCount"></param>
        /// <param name="customerEligibilityPaidSubscriptionDurationInMonths"></param>
        /// <param name="customerEligibilityWaitBetweenOffersInMonths"></param>
        /// <param name="targetSubscriptionPlanType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetentionOfferCreateRequestDataAttributes(
            string referenceName,
            string offerId,
            global::AppStoreConnect.SubscriptionOfferDuration duration,
            global::AppStoreConnect.SubscriptionOfferMode offerMode,
            int periodCount,
            int customerEligibilityPaidSubscriptionDurationInMonths,
            int? customerEligibilityWaitBetweenOffersInMonths,
            global::AppStoreConnect.SubscriptionPlanType? targetSubscriptionPlanType)
        {
            this.ReferenceName = referenceName ?? throw new global::System.ArgumentNullException(nameof(referenceName));
            this.OfferId = offerId ?? throw new global::System.ArgumentNullException(nameof(offerId));
            this.Duration = duration;
            this.OfferMode = offerMode;
            this.PeriodCount = periodCount;
            this.CustomerEligibilityPaidSubscriptionDurationInMonths = customerEligibilityPaidSubscriptionDurationInMonths;
            this.CustomerEligibilityWaitBetweenOffersInMonths = customerEligibilityWaitBetweenOffersInMonths;
            this.TargetSubscriptionPlanType = targetSubscriptionPlanType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionOfferCreateRequestDataAttributes" /> class.
        /// </summary>
        public RetentionOfferCreateRequestDataAttributes()
        {
        }

    }
}