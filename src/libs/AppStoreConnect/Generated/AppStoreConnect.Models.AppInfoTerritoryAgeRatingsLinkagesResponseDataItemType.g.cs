
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppInfoTerritoryAgeRatingsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        TerritoryAgeRatings,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoTerritoryAgeRatingsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoTerritoryAgeRatingsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppInfoTerritoryAgeRatingsLinkagesResponseDataItemType.TerritoryAgeRatings => "territoryAgeRatings",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoTerritoryAgeRatingsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "territoryAgeRatings" => AppInfoTerritoryAgeRatingsLinkagesResponseDataItemType.TerritoryAgeRatings,
                _ => null,
            };
        }
    }
}