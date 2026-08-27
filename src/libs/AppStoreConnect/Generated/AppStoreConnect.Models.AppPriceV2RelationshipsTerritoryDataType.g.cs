
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPriceV2RelationshipsTerritoryDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPriceV2RelationshipsTerritoryDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPriceV2RelationshipsTerritoryDataType value)
        {
            return value switch
            {
                AppPriceV2RelationshipsTerritoryDataType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPriceV2RelationshipsTerritoryDataType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => AppPriceV2RelationshipsTerritoryDataType.Territories,
                _ => null,
            };
        }
    }
}