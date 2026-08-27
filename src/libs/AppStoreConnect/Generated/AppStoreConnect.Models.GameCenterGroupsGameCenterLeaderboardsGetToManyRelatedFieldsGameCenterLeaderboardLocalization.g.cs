
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization
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
    public static class GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Description => "description",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.FormatterOverride => "formatterOverride",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.FormatterSuffix => "formatterSuffix",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.FormatterSuffixSingular => "formatterSuffixSingular",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.GameCenterLeaderboard => "gameCenterLeaderboard",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.GameCenterLeaderboardImage => "gameCenterLeaderboardImage",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Locale => "locale",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Description,
                "formatterOverride" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.FormatterOverride,
                "formatterSuffix" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.FormatterSuffix,
                "formatterSuffixSingular" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.FormatterSuffixSingular,
                "gameCenterLeaderboard" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.GameCenterLeaderboard,
                "gameCenterLeaderboardImage" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.GameCenterLeaderboardImage,
                "locale" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Locale,
                "name" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization.Name,
                _ => null,
            };
        }
    }
}