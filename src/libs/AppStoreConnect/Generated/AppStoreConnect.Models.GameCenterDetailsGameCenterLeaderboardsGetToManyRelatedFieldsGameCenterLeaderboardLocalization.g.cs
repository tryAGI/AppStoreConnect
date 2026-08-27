
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization
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
    public static class GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Description => "description",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.FormatterOverride => "formatterOverride",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.FormatterSuffix => "formatterSuffix",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.FormatterSuffixSingular => "formatterSuffixSingular",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.GameCenterLeaderboard => "gameCenterLeaderboard",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.GameCenterLeaderboardImage => "gameCenterLeaderboardImage",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Locale => "locale",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Description,
                "formatterOverride" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.FormatterOverride,
                "formatterSuffix" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.FormatterSuffix,
                "formatterSuffixSingular" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.FormatterSuffixSingular,
                "gameCenterLeaderboard" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.GameCenterLeaderboard,
                "gameCenterLeaderboardImage" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.GameCenterLeaderboardImage,
                "locale" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Locale,
                "name" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Name,
                _ => null,
            };
        }
    }
}