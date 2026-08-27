
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetLocalizationGameCenterLeaderboardSetImageLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSetImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetLocalizationGameCenterLeaderboardSetImageLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetLocalizationGameCenterLeaderboardSetImageLinkageResponseDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetLocalizationGameCenterLeaderboardSetImageLinkageResponseDataType.GameCenterLeaderboardSetImages => "gameCenterLeaderboardSetImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetLocalizationGameCenterLeaderboardSetImageLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSetImages" => GameCenterLeaderboardSetLocalizationGameCenterLeaderboardSetImageLinkageResponseDataType.GameCenterLeaderboardSetImages,
                _ => null,
            };
        }
    }
}