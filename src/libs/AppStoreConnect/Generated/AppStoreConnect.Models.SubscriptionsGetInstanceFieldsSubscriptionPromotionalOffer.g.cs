
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer
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
    public static class SubscriptionsGetInstanceFieldsSubscriptionPromotionalOfferExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer value)
        {
            return value switch
            {
                SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer.Duration => "duration",
                SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer.Name => "name",
                SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer.NumberOfPeriods => "numberOfPeriods",
                SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer.OfferCode => "offerCode",
                SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer.OfferMode => "offerMode",
                SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer.Prices => "prices",
                SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer.Subscription => "subscription",
                SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer.TargetSubscriptionPlanType => "targetSubscriptionPlanType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer? ToEnum(string value)
        {
            return value switch
            {
                "duration" => SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer.Duration,
                "name" => SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer.Name,
                "numberOfPeriods" => SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer.NumberOfPeriods,
                "offerCode" => SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer.OfferCode,
                "offerMode" => SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer.OfferMode,
                "prices" => SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer.Prices,
                "subscription" => SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer.Subscription,
                "targetSubscriptionPlanType" => SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer.TargetSubscriptionPlanType,
                _ => null,
            };
        }
    }
}