
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardLocalization
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
    public static class GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardLocalization value)
        {
            return value switch
            {
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardLocalization.Description => "description",
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardLocalization.FormatterOverride => "formatterOverride",
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardLocalization.FormatterSuffix => "formatterSuffix",
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardLocalization.FormatterSuffixSingular => "formatterSuffixSingular",
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardLocalization.GameCenterLeaderboard => "gameCenterLeaderboard",
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardLocalization.GameCenterLeaderboardImage => "gameCenterLeaderboardImage",
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardLocalization.Locale => "locale",
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardLocalization.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardLocalization.Description,
                "formatterOverride" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardLocalization.FormatterOverride,
                "formatterSuffix" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardLocalization.FormatterSuffix,
                "formatterSuffixSingular" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardLocalization.FormatterSuffixSingular,
                "gameCenterLeaderboard" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardLocalization.GameCenterLeaderboard,
                "gameCenterLeaderboardImage" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardLocalization.GameCenterLeaderboardImage,
                "locale" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardLocalization.Locale,
                "name" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardLocalization.Name,
                _ => null,
            };
        }
    }
}