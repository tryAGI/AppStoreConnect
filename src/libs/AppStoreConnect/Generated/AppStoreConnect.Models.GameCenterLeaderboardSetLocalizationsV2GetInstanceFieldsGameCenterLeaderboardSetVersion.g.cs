
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetVersion
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
    public static class GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetVersion value)
        {
            return value switch
            {
                GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetVersion.LeaderboardSet => "leaderboardSet",
                GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetVersion.Localizations => "localizations",
                GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetVersion.State => "state",
                GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetVersion? ToEnum(string value)
        {
            return value switch
            {
                "leaderboardSet" => GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetVersion.LeaderboardSet,
                "localizations" => GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetVersion.Localizations,
                "state" => GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetVersion.State,
                "version" => GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetVersion.Version,
                _ => null,
            };
        }
    }
}