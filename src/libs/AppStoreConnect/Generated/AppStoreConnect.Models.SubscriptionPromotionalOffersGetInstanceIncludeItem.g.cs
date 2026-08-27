
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionPromotionalOffersGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Prices,
        /// <summary>
        /// 
        /// </summary>
        Subscription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPromotionalOffersGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPromotionalOffersGetInstanceIncludeItem value)
        {
            return value switch
            {
                SubscriptionPromotionalOffersGetInstanceIncludeItem.Prices => "prices",
                SubscriptionPromotionalOffersGetInstanceIncludeItem.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPromotionalOffersGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "prices" => SubscriptionPromotionalOffersGetInstanceIncludeItem.Prices,
                "subscription" => SubscriptionPromotionalOffersGetInstanceIncludeItem.Subscription,
                _ => null,
            };
        }
    }
}