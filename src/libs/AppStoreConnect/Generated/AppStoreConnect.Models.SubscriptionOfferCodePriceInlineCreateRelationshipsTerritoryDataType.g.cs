
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionOfferCodePriceInlineCreateRelationshipsTerritoryDataType
    {
        /// <summary>
        ///
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionOfferCodePriceInlineCreateRelationshipsTerritoryDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodePriceInlineCreateRelationshipsTerritoryDataType value)
        {
            return value switch
            {
                SubscriptionOfferCodePriceInlineCreateRelationshipsTerritoryDataType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodePriceInlineCreateRelationshipsTerritoryDataType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => SubscriptionOfferCodePriceInlineCreateRelationshipsTerritoryDataType.Territories,
                _ => null,
            };
        }
    }
}