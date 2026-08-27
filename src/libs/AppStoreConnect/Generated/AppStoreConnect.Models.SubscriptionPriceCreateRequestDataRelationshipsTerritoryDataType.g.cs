
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionPriceCreateRequestDataRelationshipsTerritoryDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPriceCreateRequestDataRelationshipsTerritoryDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPriceCreateRequestDataRelationshipsTerritoryDataType value)
        {
            return value switch
            {
                SubscriptionPriceCreateRequestDataRelationshipsTerritoryDataType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPriceCreateRequestDataRelationshipsTerritoryDataType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => SubscriptionPriceCreateRequestDataRelationshipsTerritoryDataType.Territories,
                _ => null,
            };
        }
    }
}