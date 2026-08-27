
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardVersion
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
    public static class GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardVersion value)
        {
            return value switch
            {
                GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardVersion.Leaderboard => "leaderboard",
                GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardVersion.Localizations => "localizations",
                GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardVersion.State => "state",
                GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardVersion? ToEnum(string value)
        {
            return value switch
            {
                "leaderboard" => GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardVersion.Leaderboard,
                "localizations" => GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardVersion.Localizations,
                "state" => GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardVersion.State,
                "version" => GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardVersion.Version,
                _ => null,
            };
        }
    }
}