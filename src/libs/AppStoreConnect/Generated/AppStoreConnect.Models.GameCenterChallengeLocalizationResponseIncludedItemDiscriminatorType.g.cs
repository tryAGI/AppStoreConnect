
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterChallengeLocalizationResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterChallengeImages,
        /// <summary>
        /// 
        /// </summary>
        GameCenterChallengeVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeLocalizationResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeLocalizationResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterChallengeLocalizationResponseIncludedItemDiscriminatorType.GameCenterChallengeImages => "gameCenterChallengeImages",
                GameCenterChallengeLocalizationResponseIncludedItemDiscriminatorType.GameCenterChallengeVersions => "gameCenterChallengeVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeLocalizationResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallengeImages" => GameCenterChallengeLocalizationResponseIncludedItemDiscriminatorType.GameCenterChallengeImages,
                "gameCenterChallengeVersions" => GameCenterChallengeLocalizationResponseIncludedItemDiscriminatorType.GameCenterChallengeVersions,
                _ => null,
            };
        }
    }
}