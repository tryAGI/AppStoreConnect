
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization
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
    public static class GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization.GameCenterLeaderboardSet => "gameCenterLeaderboardSet",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization.GameCenterLeaderboardSetImage => "gameCenterLeaderboardSetImage",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization.Locale => "locale",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSet" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization.GameCenterLeaderboardSet,
                "gameCenterLeaderboardSetImage" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization.GameCenterLeaderboardSetImage,
                "locale" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization.Locale,
                "name" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization.Name,
                _ => null,
            };
        }
    }
}