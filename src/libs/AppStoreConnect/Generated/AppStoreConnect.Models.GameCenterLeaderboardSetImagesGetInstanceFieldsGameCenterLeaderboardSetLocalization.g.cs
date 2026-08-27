
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetLocalization
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
    public static class GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetLocalization value)
        {
            return value switch
            {
                GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetLocalization.GameCenterLeaderboardSet => "gameCenterLeaderboardSet",
                GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetLocalization.GameCenterLeaderboardSetImage => "gameCenterLeaderboardSetImage",
                GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetLocalization.Locale => "locale",
                GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetLocalization.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetLocalization? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSet" => GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetLocalization.GameCenterLeaderboardSet,
                "gameCenterLeaderboardSetImage" => GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetLocalization.GameCenterLeaderboardSetImage,
                "locale" => GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetLocalization.Locale,
                "name" => GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetLocalization.Name,
                _ => null,
            };
        }
    }
}