
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionOffer
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
    public static class RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionOfferExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionOffer value)
        {
            return value switch
            {
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionOffer.CustomerEligibilityPaidSubscriptionDurationInMonths => "customerEligibilityPaidSubscriptionDurationInMonths",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionOffer.CustomerEligibilityWaitBetweenOffersInMonths => "customerEligibilityWaitBetweenOffersInMonths",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionOffer.Duration => "duration",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionOffer.OfferId => "offerId",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionOffer.OfferMode => "offerMode",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionOffer.PeriodCount => "periodCount",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionOffer.Prices => "prices",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionOffer.ReferenceName => "referenceName",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionOffer.Subscription => "subscription",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionOffer.TargetSubscriptionPlanType => "targetSubscriptionPlanType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionOffer? ToEnum(string value)
        {
            return value switch
            {
                "customerEligibilityPaidSubscriptionDurationInMonths" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionOffer.CustomerEligibilityPaidSubscriptionDurationInMonths,
                "customerEligibilityWaitBetweenOffersInMonths" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionOffer.CustomerEligibilityWaitBetweenOffersInMonths,
                "duration" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionOffer.Duration,
                "offerId" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionOffer.OfferId,
                "offerMode" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionOffer.OfferMode,
                "periodCount" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionOffer.PeriodCount,
                "prices" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionOffer.Prices,
                "referenceName" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionOffer.ReferenceName,
                "subscription" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionOffer.Subscription,
                "targetSubscriptionPlanType" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionOffer.TargetSubscriptionPlanType,
                _ => null,
            };
        }
    }
}