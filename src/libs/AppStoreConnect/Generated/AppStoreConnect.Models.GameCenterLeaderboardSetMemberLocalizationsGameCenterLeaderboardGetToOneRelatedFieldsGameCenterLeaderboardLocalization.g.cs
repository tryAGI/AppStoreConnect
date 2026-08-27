
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardLocalization
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
    public static class GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardLocalization value)
        {
            return value switch
            {
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardLocalization.Description => "description",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardLocalization.FormatterOverride => "formatterOverride",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardLocalization.FormatterSuffix => "formatterSuffix",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardLocalization.FormatterSuffixSingular => "formatterSuffixSingular",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardLocalization.GameCenterLeaderboard => "gameCenterLeaderboard",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardLocalization.GameCenterLeaderboardImage => "gameCenterLeaderboardImage",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardLocalization.Locale => "locale",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardLocalization.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardLocalization.Description,
                "formatterOverride" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardLocalization.FormatterOverride,
                "formatterSuffix" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardLocalization.FormatterSuffix,
                "formatterSuffixSingular" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardLocalization.FormatterSuffixSingular,
                "gameCenterLeaderboard" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardLocalization.GameCenterLeaderboard,
                "gameCenterLeaderboardImage" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardLocalization.GameCenterLeaderboardImage,
                "locale" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardLocalization.Locale,
                "name" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardLocalization.Name,
                _ => null,
            };
        }
    }
}