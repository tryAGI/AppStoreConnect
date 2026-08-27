
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionOfferCodeUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionOfferCodes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionOfferCodeUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodeUpdateRequestDataType value)
        {
            return value switch
            {
                SubscriptionOfferCodeUpdateRequestDataType.SubscriptionOfferCodes => "subscriptionOfferCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodeUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionOfferCodes" => SubscriptionOfferCodeUpdateRequestDataType.SubscriptionOfferCodes,
                _ => null,
            };
        }
    }
}