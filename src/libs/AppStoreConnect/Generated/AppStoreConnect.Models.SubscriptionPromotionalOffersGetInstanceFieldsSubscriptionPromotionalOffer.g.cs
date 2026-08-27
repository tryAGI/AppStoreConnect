
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionPromotionalOffer
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
    public static class SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionPromotionalOfferExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionPromotionalOffer value)
        {
            return value switch
            {
                SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionPromotionalOffer.Duration => "duration",
                SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionPromotionalOffer.Name => "name",
                SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionPromotionalOffer.NumberOfPeriods => "numberOfPeriods",
                SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionPromotionalOffer.OfferCode => "offerCode",
                SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionPromotionalOffer.OfferMode => "offerMode",
                SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionPromotionalOffer.Prices => "prices",
                SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionPromotionalOffer.Subscription => "subscription",
                SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionPromotionalOffer.TargetSubscriptionPlanType => "targetSubscriptionPlanType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionPromotionalOffer? ToEnum(string value)
        {
            return value switch
            {
                "duration" => SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionPromotionalOffer.Duration,
                "name" => SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionPromotionalOffer.Name,
                "numberOfPeriods" => SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionPromotionalOffer.NumberOfPeriods,
                "offerCode" => SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionPromotionalOffer.OfferCode,
                "offerMode" => SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionPromotionalOffer.OfferMode,
                "prices" => SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionPromotionalOffer.Prices,
                "subscription" => SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionPromotionalOffer.Subscription,
                "targetSubscriptionPlanType" => SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionPromotionalOffer.TargetSubscriptionPlanType,
                _ => null,
            };
        }
    }
}