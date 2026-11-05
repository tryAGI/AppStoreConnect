
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsGetInstanceFieldsRetentionOffer
    {
        /// <summary>
        ///
        /// </summary>
        CustomerEligibilityPaidSubscriptionDurationInMonths,
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
        ReferenceName,
        /// <summary>
        ///
        /// </summary>
        Subscription,
        /// <summary>
        ///
        /// </summary>
        TargetSubscriptionPlanType,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionsGetInstanceFieldsRetentionOfferExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsGetInstanceFieldsRetentionOffer value)
        {
            return value switch
            {
                SubscriptionsGetInstanceFieldsRetentionOffer.CustomerEligibilityPaidSubscriptionDurationInMonths => "customerEligibilityPaidSubscriptionDurationInMonths",
                SubscriptionsGetInstanceFieldsRetentionOffer.CustomerEligibilityWaitBetweenOffersInMonths => "customerEligibilityWaitBetweenOffersInMonths",
                SubscriptionsGetInstanceFieldsRetentionOffer.Duration => "duration",
                SubscriptionsGetInstanceFieldsRetentionOffer.OfferId => "offerId",
                SubscriptionsGetInstanceFieldsRetentionOffer.OfferMode => "offerMode",
                SubscriptionsGetInstanceFieldsRetentionOffer.PeriodCount => "periodCount",
                SubscriptionsGetInstanceFieldsRetentionOffer.Prices => "prices",
                SubscriptionsGetInstanceFieldsRetentionOffer.ReferenceName => "referenceName",
                SubscriptionsGetInstanceFieldsRetentionOffer.Subscription => "subscription",
                SubscriptionsGetInstanceFieldsRetentionOffer.TargetSubscriptionPlanType => "targetSubscriptionPlanType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsGetInstanceFieldsRetentionOffer? ToEnum(string value)
        {
            return value switch
            {
                "customerEligibilityPaidSubscriptionDurationInMonths" => SubscriptionsGetInstanceFieldsRetentionOffer.CustomerEligibilityPaidSubscriptionDurationInMonths,
                "customerEligibilityWaitBetweenOffersInMonths" => SubscriptionsGetInstanceFieldsRetentionOffer.CustomerEligibilityWaitBetweenOffersInMonths,
                "duration" => SubscriptionsGetInstanceFieldsRetentionOffer.Duration,
                "offerId" => SubscriptionsGetInstanceFieldsRetentionOffer.OfferId,
                "offerMode" => SubscriptionsGetInstanceFieldsRetentionOffer.OfferMode,
                "periodCount" => SubscriptionsGetInstanceFieldsRetentionOffer.PeriodCount,
                "prices" => SubscriptionsGetInstanceFieldsRetentionOffer.Prices,
                "referenceName" => SubscriptionsGetInstanceFieldsRetentionOffer.ReferenceName,
                "subscription" => SubscriptionsGetInstanceFieldsRetentionOffer.Subscription,
                "targetSubscriptionPlanType" => SubscriptionsGetInstanceFieldsRetentionOffer.TargetSubscriptionPlanType,
                _ => null,
            };
        }
    }
}