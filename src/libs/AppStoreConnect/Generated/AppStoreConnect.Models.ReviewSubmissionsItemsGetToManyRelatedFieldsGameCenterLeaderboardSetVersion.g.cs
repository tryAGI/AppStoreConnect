
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion
    {
        /// <summary>
        ///
        /// </summary>
        LeaderboardSet,
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
    public static class ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardSetVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion value)
        {
            return value switch
            {
                ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion.LeaderboardSet => "leaderboardSet",
                ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion.Localizations => "localizations",
                ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion.State => "state",
                ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion? ToEnum(string value)
        {
            return value switch
            {
                "leaderboardSet" => ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion.LeaderboardSet,
                "localizations" => ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion.Localizations,
                "state" => ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion.State,
                "version" => ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion.Version,
                _ => null,
            };
        }
    }
}