
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionOffersGetInstanceFieldsRetentionOffer
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
    public static class RetentionOffersGetInstanceFieldsRetentionOfferExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionOffersGetInstanceFieldsRetentionOffer value)
        {
            return value switch
            {
                RetentionOffersGetInstanceFieldsRetentionOffer.CustomerEligibilityPaidSubscriptionDurationInMonths => "customerEligibilityPaidSubscriptionDurationInMonths",
                RetentionOffersGetInstanceFieldsRetentionOffer.CustomerEligibilityWaitBetweenOffersInMonths => "customerEligibilityWaitBetweenOffersInMonths",
                RetentionOffersGetInstanceFieldsRetentionOffer.Duration => "duration",
                RetentionOffersGetInstanceFieldsRetentionOffer.OfferId => "offerId",
                RetentionOffersGetInstanceFieldsRetentionOffer.OfferMode => "offerMode",
                RetentionOffersGetInstanceFieldsRetentionOffer.PeriodCount => "periodCount",
                RetentionOffersGetInstanceFieldsRetentionOffer.Prices => "prices",
                RetentionOffersGetInstanceFieldsRetentionOffer.ReferenceName => "referenceName",
                RetentionOffersGetInstanceFieldsRetentionOffer.Subscription => "subscription",
                RetentionOffersGetInstanceFieldsRetentionOffer.TargetSubscriptionPlanType => "targetSubscriptionPlanType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionOffersGetInstanceFieldsRetentionOffer? ToEnum(string value)
        {
            return value switch
            {
                "customerEligibilityPaidSubscriptionDurationInMonths" => RetentionOffersGetInstanceFieldsRetentionOffer.CustomerEligibilityPaidSubscriptionDurationInMonths,
                "customerEligibilityWaitBetweenOffersInMonths" => RetentionOffersGetInstanceFieldsRetentionOffer.CustomerEligibilityWaitBetweenOffersInMonths,
                "duration" => RetentionOffersGetInstanceFieldsRetentionOffer.Duration,
                "offerId" => RetentionOffersGetInstanceFieldsRetentionOffer.OfferId,
                "offerMode" => RetentionOffersGetInstanceFieldsRetentionOffer.OfferMode,
                "periodCount" => RetentionOffersGetInstanceFieldsRetentionOffer.PeriodCount,
                "prices" => RetentionOffersGetInstanceFieldsRetentionOffer.Prices,
                "referenceName" => RetentionOffersGetInstanceFieldsRetentionOffer.ReferenceName,
                "subscription" => RetentionOffersGetInstanceFieldsRetentionOffer.Subscription,
                "targetSubscriptionPlanType" => RetentionOffersGetInstanceFieldsRetentionOffer.TargetSubscriptionPlanType,
                _ => null,
            };
        }
    }
}