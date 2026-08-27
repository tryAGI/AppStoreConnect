
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSet,
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSetImage,
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
    public static class GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization value)
        {
            return value switch
            {
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization.GameCenterLeaderboardSet => "gameCenterLeaderboardSet",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization.GameCenterLeaderboardSetImage => "gameCenterLeaderboardSetImage",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization.Locale => "locale",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSet" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization.GameCenterLeaderboardSet,
                "gameCenterLeaderboardSetImage" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization.GameCenterLeaderboardSetImage,
                "locale" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization.Locale,
                "name" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization.Name,
                _ => null,
            };
        }
    }
}