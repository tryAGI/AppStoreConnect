
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengeVersionResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterChallengeImages,
        /// <summary>
        ///
        /// </summary>
        GameCenterChallengeLocalizations,
        /// <summary>
        ///
        /// </summary>
        GameCenterChallengeVersionReleases,
        /// <summary>
        ///
        /// </summary>
        GameCenterChallenges,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeVersionResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeVersionResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterChallengeVersionResponseIncludedItemDiscriminatorType.GameCenterChallengeImages => "gameCenterChallengeImages",
                GameCenterChallengeVersionResponseIncludedItemDiscriminatorType.GameCenterChallengeLocalizations => "gameCenterChallengeLocalizations",
                GameCenterChallengeVersionResponseIncludedItemDiscriminatorType.GameCenterChallengeVersionReleases => "gameCenterChallengeVersionReleases",
                GameCenterChallengeVersionResponseIncludedItemDiscriminatorType.GameCenterChallenges => "gameCenterChallenges",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeVersionResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallengeImages" => GameCenterChallengeVersionResponseIncludedItemDiscriminatorType.GameCenterChallengeImages,
                "gameCenterChallengeLocalizations" => GameCenterChallengeVersionResponseIncludedItemDiscriminatorType.GameCenterChallengeLocalizations,
                "gameCenterChallengeVersionReleases" => GameCenterChallengeVersionResponseIncludedItemDiscriminatorType.GameCenterChallengeVersionReleases,
                "gameCenterChallenges" => GameCenterChallengeVersionResponseIncludedItemDiscriminatorType.GameCenterChallenges,
                _ => null,
            };
        }
    }
}