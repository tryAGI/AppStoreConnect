
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionOfferPriceRelationshipsTerritoryDataType
    {
        /// <summary>
        ///
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionOfferPriceRelationshipsTerritoryDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionOfferPriceRelationshipsTerritoryDataType value)
        {
            return value switch
            {
                RetentionOfferPriceRelationshipsTerritoryDataType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionOfferPriceRelationshipsTerritoryDataType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => RetentionOfferPriceRelationshipsTerritoryDataType.Territories,
                _ => null,
            };
        }
    }
}