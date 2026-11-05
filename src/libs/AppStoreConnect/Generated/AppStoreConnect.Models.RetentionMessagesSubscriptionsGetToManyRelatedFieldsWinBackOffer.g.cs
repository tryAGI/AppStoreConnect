
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer
    {
        /// <summary>
        ///
        /// </summary>
        CustomerEligibilityPaidSubscriptionDurationInMonths,
        /// <summary>
        ///
        /// </summary>
        CustomerEligibilityTimeSinceLastSubscribedInMonths,
        /// <summary>
        ///
        /// </summary>
        CustomerEligibilityWaitBetweenOffersInMonths,
        /// <summary>
        ///
        /// </summary>
        Duration,
        /// <summary>
        ///
        /// </summary>
        EndDate,
        /// <summary>
        ///
        /// </summary>
        OfferId,
        /// <summary>
        ///
        /// </summary>
        OfferMode,
        /// <summary>
        ///
        /// </summary>
        PeriodCount,
        /// <summary>
        ///
        /// </summary>
        Prices,
        /// <summary>
        ///
        /// </summary>
        Priority,
        /// <summary>
        ///
        /// </summary>
        PromotionIntent,
        /// <summary>
        ///
        /// </summary>
        ReferenceName,
        /// <summary>
        ///
        /// </summary>
        StartDate,
        /// <summary>
        ///
        /// </summary>
        TargetSubscriptionPlanType,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOfferExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer value)
        {
            return value switch
            {
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer.CustomerEligibilityPaidSubscriptionDurationInMonths => "customerEligibilityPaidSubscriptionDurationInMonths",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer.CustomerEligibilityTimeSinceLastSubscribedInMonths => "customerEligibilityTimeSinceLastSubscribedInMonths",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer.CustomerEligibilityWaitBetweenOffersInMonths => "customerEligibilityWaitBetweenOffersInMonths",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer.Duration => "duration",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer.EndDate => "endDate",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer.OfferId => "offerId",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer.OfferMode => "offerMode",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer.PeriodCount => "periodCount",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer.Prices => "prices",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer.Priority => "priority",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer.PromotionIntent => "promotionIntent",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer.ReferenceName => "referenceName",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer.StartDate => "startDate",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer.TargetSubscriptionPlanType => "targetSubscriptionPlanType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer? ToEnum(string value)
        {
            return value switch
            {
                "customerEligibilityPaidSubscriptionDurationInMonths" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer.CustomerEligibilityPaidSubscriptionDurationInMonths,
                "customerEligibilityTimeSinceLastSubscribedInMonths" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer.CustomerEligibilityTimeSinceLastSubscribedInMonths,
                "customerEligibilityWaitBetweenOffersInMonths" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer.CustomerEligibilityWaitBetweenOffersInMonths,
                "duration" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer.Duration,
                "endDate" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer.EndDate,
                "offerId" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer.OfferId,
                "offerMode" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer.OfferMode,
                "periodCount" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer.PeriodCount,
                "prices" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer.Prices,
                "priority" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer.Priority,
                "promotionIntent" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer.PromotionIntent,
                "referenceName" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer.ReferenceName,
                "startDate" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer.StartDate,
                "targetSubscriptionPlanType" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer.TargetSubscriptionPlanType,
                _ => null,
            };
        }
    }
}