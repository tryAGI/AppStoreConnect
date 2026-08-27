
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionOfferCodeCustomCodesGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        OfferCode,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionOfferCodeCustomCodesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodeCustomCodesGetInstanceIncludeItem value)
        {
            return value switch
            {
                SubscriptionOfferCodeCustomCodesGetInstanceIncludeItem.OfferCode => "offerCode",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodeCustomCodesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "offerCode" => SubscriptionOfferCodeCustomCodesGetInstanceIncludeItem.OfferCode,
                _ => null,
            };
        }
    }
}