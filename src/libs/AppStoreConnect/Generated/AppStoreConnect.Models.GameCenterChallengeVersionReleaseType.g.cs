
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengeVersionReleaseType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterChallengeVersionReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeVersionReleaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeVersionReleaseType value)
        {
            return value switch
            {
                GameCenterChallengeVersionReleaseType.GameCenterChallengeVersionReleases => "gameCenterChallengeVersionReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeVersionReleaseType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallengeVersionReleases" => GameCenterChallengeVersionReleaseType.GameCenterChallengeVersionReleases,
                _ => null,
            };
        }
    }
}