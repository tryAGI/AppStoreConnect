
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardVersion
    {
        /// <summary>
        /// 
        /// </summary>
        Leaderboard,
        /// <summary>
        /// 
        /// </summary>
        Localizations,
        /// <summary>
        /// 
        /// </summary>
        State,
        /// <summary>
        /// 
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardVersion value)
        {
            return value switch
            {
                ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardVersion.Leaderboard => "leaderboard",
                ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardVersion.Localizations => "localizations",
                ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardVersion.State => "state",
                ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardVersion? ToEnum(string value)
        {
            return value switch
            {
                "leaderboard" => ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardVersion.Leaderboard,
                "localizations" => ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardVersion.Localizations,
                "state" => ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardVersion.State,
                "version" => ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardVersion.Version,
                _ => null,
            };
        }
    }
}