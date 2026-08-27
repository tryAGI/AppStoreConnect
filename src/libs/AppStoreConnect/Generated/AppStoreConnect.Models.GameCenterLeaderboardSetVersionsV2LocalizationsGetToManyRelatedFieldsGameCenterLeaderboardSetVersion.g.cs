
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion
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
    public static class GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion value)
        {
            return value switch
            {
                GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion.LeaderboardSet => "leaderboardSet",
                GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion.Localizations => "localizations",
                GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion.State => "state",
                GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion? ToEnum(string value)
        {
            return value switch
            {
                "leaderboardSet" => GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion.LeaderboardSet,
                "localizations" => GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion.Localizations,
                "state" => GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion.State,
                "version" => GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion.Version,
                _ => null,
            };
        }
    }
}