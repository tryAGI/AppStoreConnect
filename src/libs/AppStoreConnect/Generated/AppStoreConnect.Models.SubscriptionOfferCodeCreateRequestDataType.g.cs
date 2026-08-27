
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionOfferCodeCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionOfferCodes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionOfferCodeCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodeCreateRequestDataType value)
        {
            return value switch
            {
                SubscriptionOfferCodeCreateRequestDataType.SubscriptionOfferCodes => "subscriptionOfferCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodeCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionOfferCodes" => SubscriptionOfferCodeCreateRequestDataType.SubscriptionOfferCodes,
                _ => null,
            };
        }
    }
}