
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionOffer
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
    public static class SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionOfferExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionOffer value)
        {
            return value switch
            {
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionOffer.CustomerEligibilityPaidSubscriptionDurationInMonths => "customerEligibilityPaidSubscriptionDurationInMonths",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionOffer.CustomerEligibilityWaitBetweenOffersInMonths => "customerEligibilityWaitBetweenOffersInMonths",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionOffer.Duration => "duration",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionOffer.OfferId => "offerId",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionOffer.OfferMode => "offerMode",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionOffer.PeriodCount => "periodCount",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionOffer.Prices => "prices",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionOffer.ReferenceName => "referenceName",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionOffer.Subscription => "subscription",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionOffer.TargetSubscriptionPlanType => "targetSubscriptionPlanType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionOffer? ToEnum(string value)
        {
            return value switch
            {
                "customerEligibilityPaidSubscriptionDurationInMonths" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionOffer.CustomerEligibilityPaidSubscriptionDurationInMonths,
                "customerEligibilityWaitBetweenOffersInMonths" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionOffer.CustomerEligibilityWaitBetweenOffersInMonths,
                "duration" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionOffer.Duration,
                "offerId" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionOffer.OfferId,
                "offerMode" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionOffer.OfferMode,
                "periodCount" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionOffer.PeriodCount,
                "prices" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionOffer.Prices,
                "referenceName" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionOffer.ReferenceName,
                "subscription" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionOffer.Subscription,
                "targetSubscriptionPlanType" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionOffer.TargetSubscriptionPlanType,
                _ => null,
            };
        }
    }
}