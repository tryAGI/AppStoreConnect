
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengeLocalizationRelationshipsImageDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterChallengeImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeLocalizationRelationshipsImageDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeLocalizationRelationshipsImageDataType value)
        {
            return value switch
            {
                GameCenterChallengeLocalizationRelationshipsImageDataType.GameCenterChallengeImages => "gameCenterChallengeImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeLocalizationRelationshipsImageDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallengeImages" => GameCenterChallengeLocalizationRelationshipsImageDataType.GameCenterChallengeImages,
                _ => null,
            };
        }
    }
}