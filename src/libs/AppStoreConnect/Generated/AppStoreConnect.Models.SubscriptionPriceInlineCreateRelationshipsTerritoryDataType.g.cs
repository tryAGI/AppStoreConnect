
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPriceInlineCreateRelationshipsTerritoryDataType
    {
        /// <summary>
        ///
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPriceInlineCreateRelationshipsTerritoryDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPriceInlineCreateRelationshipsTerritoryDataType value)
        {
            return value switch
            {
                SubscriptionPriceInlineCreateRelationshipsTerritoryDataType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPriceInlineCreateRelationshipsTerritoryDataType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => SubscriptionPriceInlineCreateRelationshipsTerritoryDataType.Territories,
                _ => null,
            };
        }
    }
}