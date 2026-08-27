
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardLocalizationV2ImageLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardLocalizationV2ImageLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardLocalizationV2ImageLinkageResponseDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardLocalizationV2ImageLinkageResponseDataType.GameCenterLeaderboardImages => "gameCenterLeaderboardImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardLocalizationV2ImageLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardImages" => GameCenterLeaderboardLocalizationV2ImageLinkageResponseDataType.GameCenterLeaderboardImages,
                _ => null,
            };
        }
    }
}