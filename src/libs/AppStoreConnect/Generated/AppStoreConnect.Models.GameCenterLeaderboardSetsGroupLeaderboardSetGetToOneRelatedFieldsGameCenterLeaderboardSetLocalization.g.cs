
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization
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
    public static class GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization value)
        {
            return value switch
            {
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization.GameCenterLeaderboardSet => "gameCenterLeaderboardSet",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization.GameCenterLeaderboardSetImage => "gameCenterLeaderboardSetImage",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization.Locale => "locale",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSet" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization.GameCenterLeaderboardSet,
                "gameCenterLeaderboardSetImage" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization.GameCenterLeaderboardSetImage,
                "locale" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization.Locale,
                "name" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetLocalization.Name,
                _ => null,
            };
        }
    }
}