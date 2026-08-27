
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterChallengeVersionDefaultImageLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterChallengeImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeVersionDefaultImageLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeVersionDefaultImageLinkageResponseDataType value)
        {
            return value switch
            {
                GameCenterChallengeVersionDefaultImageLinkageResponseDataType.GameCenterChallengeImages => "gameCenterChallengeImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeVersionDefaultImageLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallengeImages" => GameCenterChallengeVersionDefaultImageLinkageResponseDataType.GameCenterChallengeImages,
                _ => null,
            };
        }
    }
}