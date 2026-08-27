
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WinBackOfferAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceName")]
        public string? ReferenceName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offerId")]
        public string? OfferId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SubscriptionOfferDurationJsonConverter))]
        public global::AppStoreConnect.SubscriptionOfferDuration? Duration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offerMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SubscriptionOfferModeJsonConverter))]
        public global::AppStoreConnect.SubscriptionOfferMode? OfferMode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("periodCount")]
        public int? PeriodCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customerEligibilityPaidSubscriptionDurationInMonths")]
        public int? CustomerEligibilityPaidSubscriptionDurationInMonths { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customerEligibilityTimeSinceLastSubscribedInMonths")]
        public global::AppStoreConnect.IntegerRange? CustomerEligibilityTimeSinceLastSubscribedInMonths { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customerEligibilityWaitBetweenOffersInMonths")]
        public int? CustomerEligibilityWaitBetweenOffersInMonths { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startDate")]
        public global::System.DateTime? StartDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endDate")]
        public global::System.DateTime? EndDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.WinBackOfferAttributesPriorityJsonConverter))]
        public global::AppStoreConnect.WinBackOfferAttributesPriority? Priority { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promotionIntent")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.WinBackOfferAttributesPromotionIntentJsonConverter))]
        public global::AppStoreConnect.WinBackOfferAttributesPromotionIntent? PromotionIntent { get; set; }

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
        /// Initializes a new instance of the <see cref="WinBackOfferAttributes" /> class.
        /// </summary>
        /// <param name="referenceName"></param>
        /// <param name="offerId"></param>
        /// <param name="duration"></param>
        /// <param name="offerMode"></param>
        /// <param name="periodCount"></param>
        /// <param name="customerEligibilityPaidSubscriptionDurationInMonths"></param>
        /// <param name="customerEligibilityTimeSinceLastSubscribedInMonths"></param>
        /// <param name="customerEligibilityWaitBetweenOffersInMonths"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="priority"></param>
        /// <param name="promotionIntent"></param>
        /// <param name="targetSubscriptionPlanType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WinBackOfferAttributes(
            string? referenceName,
            string? offerId,
            global::AppStoreConnect.SubscriptionOfferDuration? duration,
            global::AppStoreConnect.SubscriptionOfferMode? offerMode,
            int? periodCount,
            int? customerEligibilityPaidSubscriptionDurationInMonths,
            global::AppStoreConnect.IntegerRange? customerEligibilityTimeSinceLastSubscribedInMonths,
            int? customerEligibilityWaitBetweenOffersInMonths,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate,
            global::AppStoreConnect.WinBackOfferAttributesPriority? priority,
            global::AppStoreConnect.WinBackOfferAttributesPromotionIntent? promotionIntent,
            global::AppStoreConnect.SubscriptionPlanType? targetSubscriptionPlanType)
        {
            this.ReferenceName = referenceName;
            this.OfferId = offerId;
            this.Duration = duration;
            this.OfferMode = offerMode;
            this.PeriodCount = periodCount;
            this.CustomerEligibilityPaidSubscriptionDurationInMonths = customerEligibilityPaidSubscriptionDurationInMonths;
            this.CustomerEligibilityTimeSinceLastSubscribedInMonths = customerEligibilityTimeSinceLastSubscribedInMonths;
            this.CustomerEligibilityWaitBetweenOffersInMonths = customerEligibilityWaitBetweenOffersInMonths;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Priority = priority;
            this.PromotionIntent = promotionIntent;
            this.TargetSubscriptionPlanType = targetSubscriptionPlanType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinBackOfferAttributes" /> class.
        /// </summary>
        public WinBackOfferAttributes()
        {
        }

    }
}