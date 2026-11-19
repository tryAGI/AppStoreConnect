
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPriceTierRelationshipsSubscriptionPricePointDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPricePoints,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPriceTierRelationshipsSubscriptionPricePointDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPriceTierRelationshipsSubscriptionPricePointDataType value)
        {
            return value switch
            {
                SubscriptionPriceTierRelationshipsSubscriptionPricePointDataType.SubscriptionPricePoints => "subscriptionPricePoints",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPriceTierRelationshipsSubscriptionPricePointDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoints" => SubscriptionPriceTierRelationshipsSubscriptionPricePointDataType.SubscriptionPricePoints,
                _ => null,
            };
        }
    }
}