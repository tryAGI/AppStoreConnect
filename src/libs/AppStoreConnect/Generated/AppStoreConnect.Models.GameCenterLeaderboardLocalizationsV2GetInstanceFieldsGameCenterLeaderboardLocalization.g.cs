
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardLocalization
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
    public static class GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardLocalization value)
        {
            return value switch
            {
                GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardLocalization.Description => "description",
                GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardLocalization.FormatterOverride => "formatterOverride",
                GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardLocalization.FormatterSuffix => "formatterSuffix",
                GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardLocalization.FormatterSuffixSingular => "formatterSuffixSingular",
                GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardLocalization.Image => "image",
                GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardLocalization.Locale => "locale",
                GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardLocalization.Name => "name",
                GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardLocalization.Description,
                "formatterOverride" => GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardLocalization.FormatterOverride,
                "formatterSuffix" => GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardLocalization.FormatterSuffix,
                "formatterSuffixSingular" => GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardLocalization.FormatterSuffixSingular,
                "image" => GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardLocalization.Image,
                "locale" => GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardLocalization.Locale,
                "name" => GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardLocalization.Name,
                "version" => GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardLocalization.Version,
                _ => null,
            };
        }
    }
}