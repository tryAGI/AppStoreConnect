
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritoryAgeRating
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreAgeRating,
        /// <summary>
        ///
        /// </summary>
        Territory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritoryAgeRatingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritoryAgeRating value)
        {
            return value switch
            {
                AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritoryAgeRating.AppStoreAgeRating => "appStoreAgeRating",
                AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritoryAgeRating.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritoryAgeRating? ToEnum(string value)
        {
            return value switch
            {
                "appStoreAgeRating" => AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritoryAgeRating.AppStoreAgeRating,
                "territory" => AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritoryAgeRating.Territory,
                _ => null,
            };
        }
    }
}