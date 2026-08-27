
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardVersion
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
    public static class GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardVersion value)
        {
            return value switch
            {
                GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardVersion.Leaderboard => "leaderboard",
                GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardVersion.Localizations => "localizations",
                GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardVersion.State => "state",
                GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardVersion? ToEnum(string value)
        {
            return value switch
            {
                "leaderboard" => GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardVersion.Leaderboard,
                "localizations" => GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardVersion.Localizations,
                "state" => GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardVersion.State,
                "version" => GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardVersion.Version,
                _ => null,
            };
        }
    }
}