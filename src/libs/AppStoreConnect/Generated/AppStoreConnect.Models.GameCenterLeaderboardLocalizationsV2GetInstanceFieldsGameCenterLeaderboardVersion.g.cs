
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardVersion
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
    public static class GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardVersion value)
        {
            return value switch
            {
                GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardVersion.Leaderboard => "leaderboard",
                GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardVersion.Localizations => "localizations",
                GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardVersion.State => "state",
                GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardVersion? ToEnum(string value)
        {
            return value switch
            {
                "leaderboard" => GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardVersion.Leaderboard,
                "localizations" => GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardVersion.Localizations,
                "state" => GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardVersion.State,
                "version" => GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardVersion.Version,
                _ => null,
            };
        }
    }
}