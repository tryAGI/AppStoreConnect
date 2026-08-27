
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum WinBackOffersGetInstanceFieldsWinBackOffer
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
    public static class WinBackOffersGetInstanceFieldsWinBackOfferExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WinBackOffersGetInstanceFieldsWinBackOffer value)
        {
            return value switch
            {
                WinBackOffersGetInstanceFieldsWinBackOffer.CustomerEligibilityPaidSubscriptionDurationInMonths => "customerEligibilityPaidSubscriptionDurationInMonths",
                WinBackOffersGetInstanceFieldsWinBackOffer.CustomerEligibilityTimeSinceLastSubscribedInMonths => "customerEligibilityTimeSinceLastSubscribedInMonths",
                WinBackOffersGetInstanceFieldsWinBackOffer.CustomerEligibilityWaitBetweenOffersInMonths => "customerEligibilityWaitBetweenOffersInMonths",
                WinBackOffersGetInstanceFieldsWinBackOffer.Duration => "duration",
                WinBackOffersGetInstanceFieldsWinBackOffer.EndDate => "endDate",
                WinBackOffersGetInstanceFieldsWinBackOffer.OfferId => "offerId",
                WinBackOffersGetInstanceFieldsWinBackOffer.OfferMode => "offerMode",
                WinBackOffersGetInstanceFieldsWinBackOffer.PeriodCount => "periodCount",
                WinBackOffersGetInstanceFieldsWinBackOffer.Prices => "prices",
                WinBackOffersGetInstanceFieldsWinBackOffer.Priority => "priority",
                WinBackOffersGetInstanceFieldsWinBackOffer.PromotionIntent => "promotionIntent",
                WinBackOffersGetInstanceFieldsWinBackOffer.ReferenceName => "referenceName",
                WinBackOffersGetInstanceFieldsWinBackOffer.StartDate => "startDate",
                WinBackOffersGetInstanceFieldsWinBackOffer.TargetSubscriptionPlanType => "targetSubscriptionPlanType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WinBackOffersGetInstanceFieldsWinBackOffer? ToEnum(string value)
        {
            return value switch
            {
                "customerEligibilityPaidSubscriptionDurationInMonths" => WinBackOffersGetInstanceFieldsWinBackOffer.CustomerEligibilityPaidSubscriptionDurationInMonths,
                "customerEligibilityTimeSinceLastSubscribedInMonths" => WinBackOffersGetInstanceFieldsWinBackOffer.CustomerEligibilityTimeSinceLastSubscribedInMonths,
                "customerEligibilityWaitBetweenOffersInMonths" => WinBackOffersGetInstanceFieldsWinBackOffer.CustomerEligibilityWaitBetweenOffersInMonths,
                "duration" => WinBackOffersGetInstanceFieldsWinBackOffer.Duration,
                "endDate" => WinBackOffersGetInstanceFieldsWinBackOffer.EndDate,
                "offerId" => WinBackOffersGetInstanceFieldsWinBackOffer.OfferId,
                "offerMode" => WinBackOffersGetInstanceFieldsWinBackOffer.OfferMode,
                "periodCount" => WinBackOffersGetInstanceFieldsWinBackOffer.PeriodCount,
                "prices" => WinBackOffersGetInstanceFieldsWinBackOffer.Prices,
                "priority" => WinBackOffersGetInstanceFieldsWinBackOffer.Priority,
                "promotionIntent" => WinBackOffersGetInstanceFieldsWinBackOffer.PromotionIntent,
                "referenceName" => WinBackOffersGetInstanceFieldsWinBackOffer.ReferenceName,
                "startDate" => WinBackOffersGetInstanceFieldsWinBackOffer.StartDate,
                "targetSubscriptionPlanType" => WinBackOffersGetInstanceFieldsWinBackOffer.TargetSubscriptionPlanType,
                _ => null,
            };
        }
    }
}