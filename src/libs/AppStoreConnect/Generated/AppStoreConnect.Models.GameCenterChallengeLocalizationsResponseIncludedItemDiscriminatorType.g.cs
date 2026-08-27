
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengeLocalizationsResponseIncludedItemDiscriminatorType
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
    public static class GameCenterChallengeLocalizationsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeLocalizationsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterChallengeLocalizationsResponseIncludedItemDiscriminatorType.GameCenterChallengeImages => "gameCenterChallengeImages",
                GameCenterChallengeLocalizationsResponseIncludedItemDiscriminatorType.GameCenterChallengeVersions => "gameCenterChallengeVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeLocalizationsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallengeImages" => GameCenterChallengeLocalizationsResponseIncludedItemDiscriminatorType.GameCenterChallengeImages,
                "gameCenterChallengeVersions" => GameCenterChallengeLocalizationsResponseIncludedItemDiscriminatorType.GameCenterChallengeVersions,
                _ => null,
            };
        }
    }
}