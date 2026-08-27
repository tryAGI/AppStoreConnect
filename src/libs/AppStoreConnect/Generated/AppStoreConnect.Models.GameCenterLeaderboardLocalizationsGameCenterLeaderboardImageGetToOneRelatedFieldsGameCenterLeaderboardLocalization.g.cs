
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization
    {
        /// <summary>
        /// 
        /// </summary>
        Description,
        /// <summary>
        /// 
        /// </summary>
        FormatterOverride,
        /// <summary>
        /// 
        /// </summary>
        FormatterSuffix,
        /// <summary>
        /// 
        /// </summary>
        FormatterSuffixSingular,
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboard,
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardImage,
        /// <summary>
        /// 
        /// </summary>
        Locale,
        /// <summary>
        /// 
        /// </summary>
        Name,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization value)
        {
            return value switch
            {
                GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization.Description => "description",
                GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization.FormatterOverride => "formatterOverride",
                GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization.FormatterSuffix => "formatterSuffix",
                GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization.FormatterSuffixSingular => "formatterSuffixSingular",
                GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization.GameCenterLeaderboard => "gameCenterLeaderboard",
                GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization.GameCenterLeaderboardImage => "gameCenterLeaderboardImage",
                GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization.Locale => "locale",
                GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization.Description,
                "formatterOverride" => GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization.FormatterOverride,
                "formatterSuffix" => GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization.FormatterSuffix,
                "formatterSuffixSingular" => GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization.FormatterSuffixSingular,
                "gameCenterLeaderboard" => GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization.GameCenterLeaderboard,
                "gameCenterLeaderboardImage" => GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization.GameCenterLeaderboardImage,
                "locale" => GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization.Locale,
                "name" => GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization.Name,
                _ => null,
            };
        }
    }
}