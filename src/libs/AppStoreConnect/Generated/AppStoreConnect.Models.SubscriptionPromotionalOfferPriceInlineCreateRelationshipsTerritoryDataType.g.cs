
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionPromotionalOfferPriceInlineCreateRelationshipsTerritoryDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPromotionalOfferPriceInlineCreateRelationshipsTerritoryDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPromotionalOfferPriceInlineCreateRelationshipsTerritoryDataType value)
        {
            return value switch
            {
                SubscriptionPromotionalOfferPriceInlineCreateRelationshipsTerritoryDataType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPromotionalOfferPriceInlineCreateRelationshipsTerritoryDataType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => SubscriptionPromotionalOfferPriceInlineCreateRelationshipsTerritoryDataType.Territories,
                _ => null,
            };
        }
    }
}