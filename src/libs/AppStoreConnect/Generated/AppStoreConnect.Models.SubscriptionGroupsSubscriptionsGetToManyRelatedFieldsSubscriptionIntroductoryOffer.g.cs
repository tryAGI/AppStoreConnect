
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer
    {
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
        NumberOfPeriods,
        /// <summary>
        ///
        /// </summary>
        OfferMode,
        /// <summary>
        ///
        /// </summary>
        StartDate,
        /// <summary>
        ///
        /// </summary>
        Subscription,
        /// <summary>
        ///
        /// </summary>
        SubscriptionPricePoint,
        /// <summary>
        ///
        /// </summary>
        TargetSubscriptionPlanType,
        /// <summary>
        ///
        /// </summary>
        Territory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOfferExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer value)
        {
            return value switch
            {
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.Duration => "duration",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.EndDate => "endDate",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.NumberOfPeriods => "numberOfPeriods",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.OfferMode => "offerMode",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.StartDate => "startDate",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.Subscription => "subscription",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.SubscriptionPricePoint => "subscriptionPricePoint",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.TargetSubscriptionPlanType => "targetSubscriptionPlanType",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer? ToEnum(string value)
        {
            return value switch
            {
                "duration" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.Duration,
                "endDate" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.EndDate,
                "numberOfPeriods" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.NumberOfPeriods,
                "offerMode" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.OfferMode,
                "startDate" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.StartDate,
                "subscription" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.Subscription,
                "subscriptionPricePoint" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.SubscriptionPricePoint,
                "targetSubscriptionPlanType" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.TargetSubscriptionPlanType,
                "territory" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.Territory,
                _ => null,
            };
        }
    }
}