
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfosTerritoryAgeRatingsGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Territory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfosTerritoryAgeRatingsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfosTerritoryAgeRatingsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppInfosTerritoryAgeRatingsGetToManyRelatedIncludeItem.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfosTerritoryAgeRatingsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "territory" => AppInfosTerritoryAgeRatingsGetToManyRelatedIncludeItem.Territory,
                _ => null,
            };
        }
    }
}