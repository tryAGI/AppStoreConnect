
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionOfferCodeOneTimeUseCodesGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        OfferCode,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionOfferCodeOneTimeUseCodesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodeOneTimeUseCodesGetInstanceIncludeItem value)
        {
            return value switch
            {
                SubscriptionOfferCodeOneTimeUseCodesGetInstanceIncludeItem.OfferCode => "offerCode",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodeOneTimeUseCodesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "offerCode" => SubscriptionOfferCodeOneTimeUseCodesGetInstanceIncludeItem.OfferCode,
                _ => null,
            };
        }
    }
}