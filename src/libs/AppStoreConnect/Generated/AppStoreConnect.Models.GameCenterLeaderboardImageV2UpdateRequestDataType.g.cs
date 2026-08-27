
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardImageV2UpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardImageV2UpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardImageV2UpdateRequestDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardImageV2UpdateRequestDataType.GameCenterLeaderboardImages => "gameCenterLeaderboardImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardImageV2UpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardImages" => GameCenterLeaderboardImageV2UpdateRequestDataType.GameCenterLeaderboardImages,
                _ => null,
            };
        }
    }
}