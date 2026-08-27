
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengeLocalizationImageLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterChallengeImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeLocalizationImageLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeLocalizationImageLinkageResponseDataType value)
        {
            return value switch
            {
                GameCenterChallengeLocalizationImageLinkageResponseDataType.GameCenterChallengeImages => "gameCenterChallengeImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeLocalizationImageLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallengeImages" => GameCenterChallengeLocalizationImageLinkageResponseDataType.GameCenterChallengeImages,
                _ => null,
            };
        }
    }
}