
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPriceTierInlineCreateRelationshipsSubscriptionPricePointDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPricePoints,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPriceTierInlineCreateRelationshipsSubscriptionPricePointDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPriceTierInlineCreateRelationshipsSubscriptionPricePointDataType value)
        {
            return value switch
            {
                SubscriptionPriceTierInlineCreateRelationshipsSubscriptionPricePointDataType.SubscriptionPricePoints => "subscriptionPricePoints",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPriceTierInlineCreateRelationshipsSubscriptionPricePointDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoints" => SubscriptionPriceTierInlineCreateRelationshipsSubscriptionPricePointDataType.SubscriptionPricePoints,
                _ => null,
            };
        }
    }
}