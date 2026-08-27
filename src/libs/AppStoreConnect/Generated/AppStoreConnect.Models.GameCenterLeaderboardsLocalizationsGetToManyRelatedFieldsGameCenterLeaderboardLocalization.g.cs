
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization
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
    public static class GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization value)
        {
            return value switch
            {
                GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Description => "description",
                GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.FormatterOverride => "formatterOverride",
                GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.FormatterSuffix => "formatterSuffix",
                GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.FormatterSuffixSingular => "formatterSuffixSingular",
                GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.GameCenterLeaderboard => "gameCenterLeaderboard",
                GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.GameCenterLeaderboardImage => "gameCenterLeaderboardImage",
                GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Locale => "locale",
                GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Description,
                "formatterOverride" => GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.FormatterOverride,
                "formatterSuffix" => GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.FormatterSuffix,
                "formatterSuffixSingular" => GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.FormatterSuffixSingular,
                "gameCenterLeaderboard" => GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.GameCenterLeaderboard,
                "gameCenterLeaderboardImage" => GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.GameCenterLeaderboardImage,
                "locale" => GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Locale,
                "name" => GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Name,
                _ => null,
            };
        }
    }
}