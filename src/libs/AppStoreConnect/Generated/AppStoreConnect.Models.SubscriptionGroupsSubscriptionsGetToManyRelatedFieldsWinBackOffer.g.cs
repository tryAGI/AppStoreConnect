
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer
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
    public static class SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOfferExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer value)
        {
            return value switch
            {
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer.CustomerEligibilityPaidSubscriptionDurationInMonths => "customerEligibilityPaidSubscriptionDurationInMonths",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer.CustomerEligibilityTimeSinceLastSubscribedInMonths => "customerEligibilityTimeSinceLastSubscribedInMonths",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer.CustomerEligibilityWaitBetweenOffersInMonths => "customerEligibilityWaitBetweenOffersInMonths",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer.Duration => "duration",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer.EndDate => "endDate",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer.OfferId => "offerId",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer.OfferMode => "offerMode",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer.PeriodCount => "periodCount",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer.Prices => "prices",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer.Priority => "priority",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer.PromotionIntent => "promotionIntent",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer.ReferenceName => "referenceName",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer.StartDate => "startDate",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer.TargetSubscriptionPlanType => "targetSubscriptionPlanType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer? ToEnum(string value)
        {
            return value switch
            {
                "customerEligibilityPaidSubscriptionDurationInMonths" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer.CustomerEligibilityPaidSubscriptionDurationInMonths,
                "customerEligibilityTimeSinceLastSubscribedInMonths" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer.CustomerEligibilityTimeSinceLastSubscribedInMonths,
                "customerEligibilityWaitBetweenOffersInMonths" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer.CustomerEligibilityWaitBetweenOffersInMonths,
                "duration" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer.Duration,
                "endDate" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer.EndDate,
                "offerId" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer.OfferId,
                "offerMode" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer.OfferMode,
                "periodCount" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer.PeriodCount,
                "prices" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer.Prices,
                "priority" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer.Priority,
                "promotionIntent" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer.PromotionIntent,
                "referenceName" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer.ReferenceName,
                "startDate" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer.StartDate,
                "targetSubscriptionPlanType" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer.TargetSubscriptionPlanType,
                _ => null,
            };
        }
    }
}