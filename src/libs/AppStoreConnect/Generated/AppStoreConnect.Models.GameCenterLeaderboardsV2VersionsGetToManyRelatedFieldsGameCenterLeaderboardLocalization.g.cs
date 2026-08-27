
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardLocalization
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
    public static class GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardLocalization value)
        {
            return value switch
            {
                GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Description => "description",
                GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.FormatterOverride => "formatterOverride",
                GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.FormatterSuffix => "formatterSuffix",
                GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.FormatterSuffixSingular => "formatterSuffixSingular",
                GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Image => "image",
                GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Locale => "locale",
                GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Name => "name",
                GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Description,
                "formatterOverride" => GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.FormatterOverride,
                "formatterSuffix" => GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.FormatterSuffix,
                "formatterSuffixSingular" => GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.FormatterSuffixSingular,
                "image" => GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Image,
                "locale" => GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Locale,
                "name" => GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Name,
                "version" => GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Version,
                _ => null,
            };
        }
    }
}