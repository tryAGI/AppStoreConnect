
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOffer
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
    public static class SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOfferExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOffer value)
        {
            return value switch
            {
                SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOffer.Duration => "duration",
                SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOffer.Name => "name",
                SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOffer.NumberOfPeriods => "numberOfPeriods",
                SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOffer.OfferCode => "offerCode",
                SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOffer.OfferMode => "offerMode",
                SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOffer.Prices => "prices",
                SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOffer.Subscription => "subscription",
                SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOffer.TargetSubscriptionPlanType => "targetSubscriptionPlanType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOffer? ToEnum(string value)
        {
            return value switch
            {
                "duration" => SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOffer.Duration,
                "name" => SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOffer.Name,
                "numberOfPeriods" => SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOffer.NumberOfPeriods,
                "offerCode" => SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOffer.OfferCode,
                "offerMode" => SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOffer.OfferMode,
                "prices" => SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOffer.Prices,
                "subscription" => SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOffer.Subscription,
                "targetSubscriptionPlanType" => SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOffer.TargetSubscriptionPlanType,
                _ => null,
            };
        }
    }
}