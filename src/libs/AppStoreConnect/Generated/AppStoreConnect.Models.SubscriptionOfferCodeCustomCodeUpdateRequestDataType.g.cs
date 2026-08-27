
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionOfferCodeCustomCodeUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionOfferCodeCustomCodes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionOfferCodeCustomCodeUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodeCustomCodeUpdateRequestDataType value)
        {
            return value switch
            {
                SubscriptionOfferCodeCustomCodeUpdateRequestDataType.SubscriptionOfferCodeCustomCodes => "subscriptionOfferCodeCustomCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodeCustomCodeUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionOfferCodeCustomCodes" => SubscriptionOfferCodeCustomCodeUpdateRequestDataType.SubscriptionOfferCodeCustomCodes,
                _ => null,
            };
        }
    }
}