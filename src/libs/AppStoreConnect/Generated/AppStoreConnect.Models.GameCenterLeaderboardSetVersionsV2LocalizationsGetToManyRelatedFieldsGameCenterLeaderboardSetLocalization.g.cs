
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization
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
    public static class GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization value)
        {
            return value switch
            {
                GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization.Image => "image",
                GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization.Locale => "locale",
                GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization.Name => "name",
                GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization? ToEnum(string value)
        {
            return value switch
            {
                "image" => GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization.Image,
                "locale" => GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization.Locale,
                "name" => GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization.Name,
                "version" => GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization.Version,
                _ => null,
            };
        }
    }
}