
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPriceTierEqualizationRelationshipsPriceTierPricePointsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPricePoints,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPriceTierEqualizationRelationshipsPriceTierPricePointsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPriceTierEqualizationRelationshipsPriceTierPricePointsDataItemType value)
        {
            return value switch
            {
                SubscriptionPriceTierEqualizationRelationshipsPriceTierPricePointsDataItemType.SubscriptionPricePoints => "subscriptionPricePoints",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPriceTierEqualizationRelationshipsPriceTierPricePointsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoints" => SubscriptionPriceTierEqualizationRelationshipsPriceTierPricePointsDataItemType.SubscriptionPricePoints,
                _ => null,
            };
        }
    }
}