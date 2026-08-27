
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionOfferCodesGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        CustomCodes,
        /// <summary>
        /// 
        /// </summary>
        OneTimeUseCodes,
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
    public static class SubscriptionOfferCodesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodesGetInstanceIncludeItem value)
        {
            return value switch
            {
                SubscriptionOfferCodesGetInstanceIncludeItem.CustomCodes => "customCodes",
                SubscriptionOfferCodesGetInstanceIncludeItem.OneTimeUseCodes => "oneTimeUseCodes",
                SubscriptionOfferCodesGetInstanceIncludeItem.Prices => "prices",
                SubscriptionOfferCodesGetInstanceIncludeItem.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "customCodes" => SubscriptionOfferCodesGetInstanceIncludeItem.CustomCodes,
                "oneTimeUseCodes" => SubscriptionOfferCodesGetInstanceIncludeItem.OneTimeUseCodes,
                "prices" => SubscriptionOfferCodesGetInstanceIncludeItem.Prices,
                "subscription" => SubscriptionOfferCodesGetInstanceIncludeItem.Subscription,
                _ => null,
            };
        }
    }
}