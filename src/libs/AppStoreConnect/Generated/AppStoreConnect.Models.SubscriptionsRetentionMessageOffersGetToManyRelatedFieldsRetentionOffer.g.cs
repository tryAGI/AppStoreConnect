
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsRetentionOffer
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
    public static class SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsRetentionOfferExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsRetentionOffer value)
        {
            return value switch
            {
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsRetentionOffer.CustomerEligibilityPaidSubscriptionDurationInMonths => "customerEligibilityPaidSubscriptionDurationInMonths",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsRetentionOffer.CustomerEligibilityWaitBetweenOffersInMonths => "customerEligibilityWaitBetweenOffersInMonths",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsRetentionOffer.Duration => "duration",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsRetentionOffer.OfferId => "offerId",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsRetentionOffer.OfferMode => "offerMode",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsRetentionOffer.PeriodCount => "periodCount",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsRetentionOffer.Prices => "prices",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsRetentionOffer.ReferenceName => "referenceName",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsRetentionOffer.Subscription => "subscription",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsRetentionOffer.TargetSubscriptionPlanType => "targetSubscriptionPlanType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsRetentionOffer? ToEnum(string value)
        {
            return value switch
            {
                "customerEligibilityPaidSubscriptionDurationInMonths" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsRetentionOffer.CustomerEligibilityPaidSubscriptionDurationInMonths,
                "customerEligibilityWaitBetweenOffersInMonths" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsRetentionOffer.CustomerEligibilityWaitBetweenOffersInMonths,
                "duration" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsRetentionOffer.Duration,
                "offerId" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsRetentionOffer.OfferId,
                "offerMode" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsRetentionOffer.OfferMode,
                "periodCount" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsRetentionOffer.PeriodCount,
                "prices" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsRetentionOffer.Prices,
                "referenceName" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsRetentionOffer.ReferenceName,
                "subscription" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsRetentionOffer.Subscription,
                "targetSubscriptionPlanType" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsRetentionOffer.TargetSubscriptionPlanType,
                _ => null,
            };
        }
    }
}