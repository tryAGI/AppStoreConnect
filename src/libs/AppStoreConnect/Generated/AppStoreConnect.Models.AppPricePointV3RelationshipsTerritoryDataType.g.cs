
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPricePointV3RelationshipsTerritoryDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPricePointV3RelationshipsTerritoryDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPricePointV3RelationshipsTerritoryDataType value)
        {
            return value switch
            {
                AppPricePointV3RelationshipsTerritoryDataType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPricePointV3RelationshipsTerritoryDataType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => AppPricePointV3RelationshipsTerritoryDataType.Territories,
                _ => null,
            };
        }
    }
}