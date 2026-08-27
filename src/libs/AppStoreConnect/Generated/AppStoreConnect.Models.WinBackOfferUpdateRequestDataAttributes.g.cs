
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WinBackOfferUpdateRequestDataAttributes
    {
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.WinBackOfferUpdateRequestDataAttributesPriorityJsonConverter))]
        public global::AppStoreConnect.WinBackOfferUpdateRequestDataAttributesPriority? Priority { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promotionIntent")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.WinBackOfferUpdateRequestDataAttributesPromotionIntentJsonConverter))]
        public global::AppStoreConnect.WinBackOfferUpdateRequestDataAttributesPromotionIntent? PromotionIntent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WinBackOfferUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="customerEligibilityPaidSubscriptionDurationInMonths"></param>
        /// <param name="customerEligibilityTimeSinceLastSubscribedInMonths"></param>
        /// <param name="customerEligibilityWaitBetweenOffersInMonths"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="priority"></param>
        /// <param name="promotionIntent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WinBackOfferUpdateRequestDataAttributes(
            int? customerEligibilityPaidSubscriptionDurationInMonths,
            global::AppStoreConnect.IntegerRange? customerEligibilityTimeSinceLastSubscribedInMonths,
            int? customerEligibilityWaitBetweenOffersInMonths,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate,
            global::AppStoreConnect.WinBackOfferUpdateRequestDataAttributesPriority? priority,
            global::AppStoreConnect.WinBackOfferUpdateRequestDataAttributesPromotionIntent? promotionIntent)
        {
            this.CustomerEligibilityPaidSubscriptionDurationInMonths = customerEligibilityPaidSubscriptionDurationInMonths;
            this.CustomerEligibilityTimeSinceLastSubscribedInMonths = customerEligibilityTimeSinceLastSubscribedInMonths;
            this.CustomerEligibilityWaitBetweenOffersInMonths = customerEligibilityWaitBetweenOffersInMonths;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Priority = priority;
            this.PromotionIntent = promotionIntent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinBackOfferUpdateRequestDataAttributes" /> class.
        /// </summary>
        public WinBackOfferUpdateRequestDataAttributes()
        {
        }

    }
}