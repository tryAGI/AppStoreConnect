
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterChallengeVersionsResponseIncludedItemDiscriminatorType
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
    public static class GameCenterChallengeVersionsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeVersionsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterChallengeVersionsResponseIncludedItemDiscriminatorType.GameCenterChallengeImages => "gameCenterChallengeImages",
                GameCenterChallengeVersionsResponseIncludedItemDiscriminatorType.GameCenterChallengeLocalizations => "gameCenterChallengeLocalizations",
                GameCenterChallengeVersionsResponseIncludedItemDiscriminatorType.GameCenterChallengeVersionReleases => "gameCenterChallengeVersionReleases",
                GameCenterChallengeVersionsResponseIncludedItemDiscriminatorType.GameCenterChallenges => "gameCenterChallenges",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeVersionsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallengeImages" => GameCenterChallengeVersionsResponseIncludedItemDiscriminatorType.GameCenterChallengeImages,
                "gameCenterChallengeLocalizations" => GameCenterChallengeVersionsResponseIncludedItemDiscriminatorType.GameCenterChallengeLocalizations,
                "gameCenterChallengeVersionReleases" => GameCenterChallengeVersionsResponseIncludedItemDiscriminatorType.GameCenterChallengeVersionReleases,
                "gameCenterChallenges" => GameCenterChallengeVersionsResponseIncludedItemDiscriminatorType.GameCenterChallenges,
                _ => null,
            };
        }
    }
}