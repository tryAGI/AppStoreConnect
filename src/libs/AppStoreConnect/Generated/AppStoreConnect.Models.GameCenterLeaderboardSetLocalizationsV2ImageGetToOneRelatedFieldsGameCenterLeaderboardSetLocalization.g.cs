
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization
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
    public static class GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardSetLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization value)
        {
            return value switch
            {
                GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization.Image => "image",
                GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization.Locale => "locale",
                GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization.Name => "name",
                GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization? ToEnum(string value)
        {
            return value switch
            {
                "image" => GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization.Image,
                "locale" => GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization.Locale,
                "name" => GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization.Name,
                "version" => GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization.Version,
                _ => null,
            };
        }
    }
}