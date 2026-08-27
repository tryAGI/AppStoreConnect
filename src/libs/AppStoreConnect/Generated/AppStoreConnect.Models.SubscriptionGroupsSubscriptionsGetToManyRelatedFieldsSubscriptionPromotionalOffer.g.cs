
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer
    {
        /// <summary>
        ///
        /// </summary>
        Duration,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        NumberOfPeriods,
        /// <summary>
        ///
        /// </summary>
        OfferCode,
        /// <summary>
        ///
        /// </summary>
        OfferMode,
        /// <summary>
        ///
        /// </summary>
        Prices,
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
    public static class SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOfferExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer value)
        {
            return value switch
            {
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer.Duration => "duration",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer.Name => "name",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer.NumberOfPeriods => "numberOfPeriods",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer.OfferCode => "offerCode",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer.OfferMode => "offerMode",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer.Prices => "prices",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer.Subscription => "subscription",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer.TargetSubscriptionPlanType => "targetSubscriptionPlanType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer? ToEnum(string value)
        {
            return value switch
            {
                "duration" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer.Duration,
                "name" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer.Name,
                "numberOfPeriods" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer.NumberOfPeriods,
                "offerCode" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer.OfferCode,
                "offerMode" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer.OfferMode,
                "prices" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer.Prices,
                "subscription" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer.Subscription,
                "targetSubscriptionPlanType" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer.TargetSubscriptionPlanType,
                _ => null,
            };
        }
    }
}