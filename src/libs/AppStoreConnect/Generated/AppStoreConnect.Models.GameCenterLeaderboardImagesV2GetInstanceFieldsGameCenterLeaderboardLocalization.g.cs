
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardLocalization
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
    public static class GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardLocalization value)
        {
            return value switch
            {
                GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardLocalization.Description => "description",
                GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardLocalization.FormatterOverride => "formatterOverride",
                GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardLocalization.FormatterSuffix => "formatterSuffix",
                GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardLocalization.FormatterSuffixSingular => "formatterSuffixSingular",
                GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardLocalization.Image => "image",
                GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardLocalization.Locale => "locale",
                GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardLocalization.Name => "name",
                GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardLocalization.Description,
                "formatterOverride" => GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardLocalization.FormatterOverride,
                "formatterSuffix" => GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardLocalization.FormatterSuffix,
                "formatterSuffixSingular" => GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardLocalization.FormatterSuffixSingular,
                "image" => GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardLocalization.Image,
                "locale" => GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardLocalization.Locale,
                "name" => GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardLocalization.Name,
                "version" => GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardLocalization.Version,
                _ => null,
            };
        }
    }
}