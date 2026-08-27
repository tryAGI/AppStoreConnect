
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetImageDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSetImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetImageDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetImageDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetImageDataType.GameCenterLeaderboardSetImages => "gameCenterLeaderboardSetImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetImageDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSetImages" => GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetImageDataType.GameCenterLeaderboardSetImages,
                _ => null,
            };
        }
    }
}