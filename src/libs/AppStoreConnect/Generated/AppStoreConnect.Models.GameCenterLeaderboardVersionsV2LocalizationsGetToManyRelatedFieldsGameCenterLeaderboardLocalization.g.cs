
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization
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
    public static class GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization value)
        {
            return value switch
            {
                GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Description => "description",
                GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.FormatterOverride => "formatterOverride",
                GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.FormatterSuffix => "formatterSuffix",
                GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.FormatterSuffixSingular => "formatterSuffixSingular",
                GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Image => "image",
                GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Locale => "locale",
                GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Name => "name",
                GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Description,
                "formatterOverride" => GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.FormatterOverride,
                "formatterSuffix" => GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.FormatterSuffix,
                "formatterSuffixSingular" => GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.FormatterSuffixSingular,
                "image" => GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Image,
                "locale" => GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Locale,
                "name" => GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Name,
                "version" => GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Version,
                _ => null,
            };
        }
    }
}