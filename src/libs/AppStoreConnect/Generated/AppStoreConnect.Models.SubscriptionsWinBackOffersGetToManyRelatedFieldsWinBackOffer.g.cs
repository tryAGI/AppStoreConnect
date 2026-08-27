
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer
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
    public static class SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer value)
        {
            return value switch
            {
                SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer.CustomerEligibilityPaidSubscriptionDurationInMonths => "customerEligibilityPaidSubscriptionDurationInMonths",
                SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer.CustomerEligibilityTimeSinceLastSubscribedInMonths => "customerEligibilityTimeSinceLastSubscribedInMonths",
                SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer.CustomerEligibilityWaitBetweenOffersInMonths => "customerEligibilityWaitBetweenOffersInMonths",
                SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer.Duration => "duration",
                SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer.EndDate => "endDate",
                SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer.OfferId => "offerId",
                SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer.OfferMode => "offerMode",
                SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer.PeriodCount => "periodCount",
                SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer.Prices => "prices",
                SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer.Priority => "priority",
                SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer.PromotionIntent => "promotionIntent",
                SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer.ReferenceName => "referenceName",
                SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer.StartDate => "startDate",
                SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer.TargetSubscriptionPlanType => "targetSubscriptionPlanType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer? ToEnum(string value)
        {
            return value switch
            {
                "customerEligibilityPaidSubscriptionDurationInMonths" => SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer.CustomerEligibilityPaidSubscriptionDurationInMonths,
                "customerEligibilityTimeSinceLastSubscribedInMonths" => SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer.CustomerEligibilityTimeSinceLastSubscribedInMonths,
                "customerEligibilityWaitBetweenOffersInMonths" => SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer.CustomerEligibilityWaitBetweenOffersInMonths,
                "duration" => SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer.Duration,
                "endDate" => SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer.EndDate,
                "offerId" => SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer.OfferId,
                "offerMode" => SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer.OfferMode,
                "periodCount" => SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer.PeriodCount,
                "prices" => SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer.Prices,
                "priority" => SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer.Priority,
                "promotionIntent" => SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer.PromotionIntent,
                "referenceName" => SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer.ReferenceName,
                "startDate" => SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer.StartDate,
                "targetSubscriptionPlanType" => SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer.TargetSubscriptionPlanType,
                _ => null,
            };
        }
    }
}