
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPriceTierEqualizationCreateRequestDataRelationshipsBasePricePointDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPricePoints,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPriceTierEqualizationCreateRequestDataRelationshipsBasePricePointDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPriceTierEqualizationCreateRequestDataRelationshipsBasePricePointDataType value)
        {
            return value switch
            {
                SubscriptionPriceTierEqualizationCreateRequestDataRelationshipsBasePricePointDataType.SubscriptionPricePoints => "subscriptionPricePoints",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPriceTierEqualizationCreateRequestDataRelationshipsBasePricePointDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoints" => SubscriptionPriceTierEqualizationCreateRequestDataRelationshipsBasePricePointDataType.SubscriptionPricePoints,
                _ => null,
            };
        }
    }
}