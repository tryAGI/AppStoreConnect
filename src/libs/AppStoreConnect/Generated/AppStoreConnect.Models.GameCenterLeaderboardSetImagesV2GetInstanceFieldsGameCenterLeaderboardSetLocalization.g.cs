
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetImagesV2GetInstanceFieldsGameCenterLeaderboardSetLocalization
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
    public static class GameCenterLeaderboardSetImagesV2GetInstanceFieldsGameCenterLeaderboardSetLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetImagesV2GetInstanceFieldsGameCenterLeaderboardSetLocalization value)
        {
            return value switch
            {
                GameCenterLeaderboardSetImagesV2GetInstanceFieldsGameCenterLeaderboardSetLocalization.Image => "image",
                GameCenterLeaderboardSetImagesV2GetInstanceFieldsGameCenterLeaderboardSetLocalization.Locale => "locale",
                GameCenterLeaderboardSetImagesV2GetInstanceFieldsGameCenterLeaderboardSetLocalization.Name => "name",
                GameCenterLeaderboardSetImagesV2GetInstanceFieldsGameCenterLeaderboardSetLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetImagesV2GetInstanceFieldsGameCenterLeaderboardSetLocalization? ToEnum(string value)
        {
            return value switch
            {
                "image" => GameCenterLeaderboardSetImagesV2GetInstanceFieldsGameCenterLeaderboardSetLocalization.Image,
                "locale" => GameCenterLeaderboardSetImagesV2GetInstanceFieldsGameCenterLeaderboardSetLocalization.Locale,
                "name" => GameCenterLeaderboardSetImagesV2GetInstanceFieldsGameCenterLeaderboardSetLocalization.Name,
                "version" => GameCenterLeaderboardSetImagesV2GetInstanceFieldsGameCenterLeaderboardSetLocalization.Version,
                _ => null,
            };
        }
    }
}