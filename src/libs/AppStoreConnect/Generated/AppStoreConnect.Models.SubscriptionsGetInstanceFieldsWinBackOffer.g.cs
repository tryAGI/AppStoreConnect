
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsGetInstanceFieldsWinBackOffer
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
    public static class SubscriptionsGetInstanceFieldsWinBackOfferExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsGetInstanceFieldsWinBackOffer value)
        {
            return value switch
            {
                SubscriptionsGetInstanceFieldsWinBackOffer.CustomerEligibilityPaidSubscriptionDurationInMonths => "customerEligibilityPaidSubscriptionDurationInMonths",
                SubscriptionsGetInstanceFieldsWinBackOffer.CustomerEligibilityTimeSinceLastSubscribedInMonths => "customerEligibilityTimeSinceLastSubscribedInMonths",
                SubscriptionsGetInstanceFieldsWinBackOffer.CustomerEligibilityWaitBetweenOffersInMonths => "customerEligibilityWaitBetweenOffersInMonths",
                SubscriptionsGetInstanceFieldsWinBackOffer.Duration => "duration",
                SubscriptionsGetInstanceFieldsWinBackOffer.EndDate => "endDate",
                SubscriptionsGetInstanceFieldsWinBackOffer.OfferId => "offerId",
                SubscriptionsGetInstanceFieldsWinBackOffer.OfferMode => "offerMode",
                SubscriptionsGetInstanceFieldsWinBackOffer.PeriodCount => "periodCount",
                SubscriptionsGetInstanceFieldsWinBackOffer.Prices => "prices",
                SubscriptionsGetInstanceFieldsWinBackOffer.Priority => "priority",
                SubscriptionsGetInstanceFieldsWinBackOffer.PromotionIntent => "promotionIntent",
                SubscriptionsGetInstanceFieldsWinBackOffer.ReferenceName => "referenceName",
                SubscriptionsGetInstanceFieldsWinBackOffer.StartDate => "startDate",
                SubscriptionsGetInstanceFieldsWinBackOffer.TargetSubscriptionPlanType => "targetSubscriptionPlanType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsGetInstanceFieldsWinBackOffer? ToEnum(string value)
        {
            return value switch
            {
                "customerEligibilityPaidSubscriptionDurationInMonths" => SubscriptionsGetInstanceFieldsWinBackOffer.CustomerEligibilityPaidSubscriptionDurationInMonths,
                "customerEligibilityTimeSinceLastSubscribedInMonths" => SubscriptionsGetInstanceFieldsWinBackOffer.CustomerEligibilityTimeSinceLastSubscribedInMonths,
                "customerEligibilityWaitBetweenOffersInMonths" => SubscriptionsGetInstanceFieldsWinBackOffer.CustomerEligibilityWaitBetweenOffersInMonths,
                "duration" => SubscriptionsGetInstanceFieldsWinBackOffer.Duration,
                "endDate" => SubscriptionsGetInstanceFieldsWinBackOffer.EndDate,
                "offerId" => SubscriptionsGetInstanceFieldsWinBackOffer.OfferId,
                "offerMode" => SubscriptionsGetInstanceFieldsWinBackOffer.OfferMode,
                "periodCount" => SubscriptionsGetInstanceFieldsWinBackOffer.PeriodCount,
                "prices" => SubscriptionsGetInstanceFieldsWinBackOffer.Prices,
                "priority" => SubscriptionsGetInstanceFieldsWinBackOffer.Priority,
                "promotionIntent" => SubscriptionsGetInstanceFieldsWinBackOffer.PromotionIntent,
                "referenceName" => SubscriptionsGetInstanceFieldsWinBackOffer.ReferenceName,
                "startDate" => SubscriptionsGetInstanceFieldsWinBackOffer.StartDate,
                "targetSubscriptionPlanType" => SubscriptionsGetInstanceFieldsWinBackOffer.TargetSubscriptionPlanType,
                _ => null,
            };
        }
    }
}