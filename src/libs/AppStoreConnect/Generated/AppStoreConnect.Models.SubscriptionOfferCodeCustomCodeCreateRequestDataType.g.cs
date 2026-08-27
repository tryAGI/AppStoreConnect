
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionOfferCodeCustomCodeCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionOfferCodeCustomCodes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionOfferCodeCustomCodeCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodeCustomCodeCreateRequestDataType value)
        {
            return value switch
            {
                SubscriptionOfferCodeCustomCodeCreateRequestDataType.SubscriptionOfferCodeCustomCodes => "subscriptionOfferCodeCustomCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodeCustomCodeCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionOfferCodeCustomCodes" => SubscriptionOfferCodeCustomCodeCreateRequestDataType.SubscriptionOfferCodeCustomCodes,
                _ => null,
            };
        }
    }
}