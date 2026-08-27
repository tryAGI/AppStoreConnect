
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionOfferCodeCustomCodesLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionOfferCodeCustomCodes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionOfferCodeCustomCodesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodeCustomCodesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                SubscriptionOfferCodeCustomCodesLinkagesResponseDataItemType.SubscriptionOfferCodeCustomCodes => "subscriptionOfferCodeCustomCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodeCustomCodesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionOfferCodeCustomCodes" => SubscriptionOfferCodeCustomCodesLinkagesResponseDataItemType.SubscriptionOfferCodeCustomCodes,
                _ => null,
            };
        }
    }
}