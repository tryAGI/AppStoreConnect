
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetLocalization
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
    public static class GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetLocalization value)
        {
            return value switch
            {
                GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetLocalization.Image => "image",
                GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetLocalization.Locale => "locale",
                GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetLocalization.Name => "name",
                GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetLocalization? ToEnum(string value)
        {
            return value switch
            {
                "image" => GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetLocalization.Image,
                "locale" => GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetLocalization.Locale,
                "name" => GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetLocalization.Name,
                "version" => GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetLocalization.Version,
                _ => null,
            };
        }
    }
}