
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetVersionsV2GetInstanceFieldsGameCenterLeaderboardSetLocalization
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Locale,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetVersionsV2GetInstanceFieldsGameCenterLeaderboardSetLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetVersionsV2GetInstanceFieldsGameCenterLeaderboardSetLocalization value)
        {
            return value switch
            {
                GameCenterLeaderboardSetVersionsV2GetInstanceFieldsGameCenterLeaderboardSetLocalization.Image => "image",
                GameCenterLeaderboardSetVersionsV2GetInstanceFieldsGameCenterLeaderboardSetLocalization.Locale => "locale",
                GameCenterLeaderboardSetVersionsV2GetInstanceFieldsGameCenterLeaderboardSetLocalization.Name => "name",
                GameCenterLeaderboardSetVersionsV2GetInstanceFieldsGameCenterLeaderboardSetLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetVersionsV2GetInstanceFieldsGameCenterLeaderboardSetLocalization? ToEnum(string value)
        {
            return value switch
            {
                "image" => GameCenterLeaderboardSetVersionsV2GetInstanceFieldsGameCenterLeaderboardSetLocalization.Image,
                "locale" => GameCenterLeaderboardSetVersionsV2GetInstanceFieldsGameCenterLeaderboardSetLocalization.Locale,
                "name" => GameCenterLeaderboardSetVersionsV2GetInstanceFieldsGameCenterLeaderboardSetLocalization.Name,
                "version" => GameCenterLeaderboardSetVersionsV2GetInstanceFieldsGameCenterLeaderboardSetLocalization.Version,
                _ => null,
            };
        }
    }
}