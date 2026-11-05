
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOffer
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
    public static class SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOfferExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOffer value)
        {
            return value switch
            {
                SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOffer.CustomerEligibilityPaidSubscriptionDurationInMonths => "customerEligibilityPaidSubscriptionDurationInMonths",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOffer.CustomerEligibilityWaitBetweenOffersInMonths => "customerEligibilityWaitBetweenOffersInMonths",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOffer.Duration => "duration",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOffer.OfferId => "offerId",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOffer.OfferMode => "offerMode",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOffer.PeriodCount => "periodCount",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOffer.Prices => "prices",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOffer.ReferenceName => "referenceName",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOffer.Subscription => "subscription",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOffer.TargetSubscriptionPlanType => "targetSubscriptionPlanType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOffer? ToEnum(string value)
        {
            return value switch
            {
                "customerEligibilityPaidSubscriptionDurationInMonths" => SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOffer.CustomerEligibilityPaidSubscriptionDurationInMonths,
                "customerEligibilityWaitBetweenOffersInMonths" => SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOffer.CustomerEligibilityWaitBetweenOffersInMonths,
                "duration" => SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOffer.Duration,
                "offerId" => SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOffer.OfferId,
                "offerMode" => SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOffer.OfferMode,
                "periodCount" => SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOffer.PeriodCount,
                "prices" => SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOffer.Prices,
                "referenceName" => SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOffer.ReferenceName,
                "subscription" => SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOffer.Subscription,
                "targetSubscriptionPlanType" => SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOffer.TargetSubscriptionPlanType,
                _ => null,
            };
        }
    }
}