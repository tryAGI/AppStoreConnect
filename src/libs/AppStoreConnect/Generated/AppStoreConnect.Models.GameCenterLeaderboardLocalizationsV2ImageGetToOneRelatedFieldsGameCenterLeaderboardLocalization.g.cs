
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization
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
    public static class GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization value)
        {
            return value switch
            {
                GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization.Description => "description",
                GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization.FormatterOverride => "formatterOverride",
                GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization.FormatterSuffix => "formatterSuffix",
                GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization.FormatterSuffixSingular => "formatterSuffixSingular",
                GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization.Image => "image",
                GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization.Locale => "locale",
                GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization.Name => "name",
                GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization.Description,
                "formatterOverride" => GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization.FormatterOverride,
                "formatterSuffix" => GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization.FormatterSuffix,
                "formatterSuffixSingular" => GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization.FormatterSuffixSingular,
                "image" => GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization.Image,
                "locale" => GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization.Locale,
                "name" => GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization.Name,
                "version" => GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization.Version,
                _ => null,
            };
        }
    }
}