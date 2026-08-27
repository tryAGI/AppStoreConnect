
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion
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
    public static class GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion.Leaderboard => "leaderboard",
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion.Localizations => "localizations",
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion.State => "state",
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion? ToEnum(string value)
        {
            return value switch
            {
                "leaderboard" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion.Leaderboard,
                "localizations" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion.Localizations,
                "state" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion.State,
                "version" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion.Version,
                _ => null,
            };
        }
    }
}