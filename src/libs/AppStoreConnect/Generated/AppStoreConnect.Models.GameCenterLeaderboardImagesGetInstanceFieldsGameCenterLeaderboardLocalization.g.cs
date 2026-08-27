
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardLocalization
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
    public static class GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardLocalization value)
        {
            return value switch
            {
                GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardLocalization.Description => "description",
                GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardLocalization.FormatterOverride => "formatterOverride",
                GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardLocalization.FormatterSuffix => "formatterSuffix",
                GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardLocalization.FormatterSuffixSingular => "formatterSuffixSingular",
                GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardLocalization.GameCenterLeaderboard => "gameCenterLeaderboard",
                GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardLocalization.GameCenterLeaderboardImage => "gameCenterLeaderboardImage",
                GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardLocalization.Locale => "locale",
                GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardLocalization.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardLocalization.Description,
                "formatterOverride" => GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardLocalization.FormatterOverride,
                "formatterSuffix" => GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardLocalization.FormatterSuffix,
                "formatterSuffixSingular" => GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardLocalization.FormatterSuffixSingular,
                "gameCenterLeaderboard" => GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardLocalization.GameCenterLeaderboard,
                "gameCenterLeaderboardImage" => GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardLocalization.GameCenterLeaderboardImage,
                "locale" => GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardLocalization.Locale,
                "name" => GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardLocalization.Name,
                _ => null,
            };
        }
    }
}