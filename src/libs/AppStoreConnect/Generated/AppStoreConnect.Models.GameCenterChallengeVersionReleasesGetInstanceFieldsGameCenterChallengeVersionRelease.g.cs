
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengeVersionReleasesGetInstanceFieldsGameCenterChallengeVersionRelease
    {
        /// <summary>
        ///
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeVersionReleasesGetInstanceFieldsGameCenterChallengeVersionReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeVersionReleasesGetInstanceFieldsGameCenterChallengeVersionRelease value)
        {
            return value switch
            {
                GameCenterChallengeVersionReleasesGetInstanceFieldsGameCenterChallengeVersionRelease.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeVersionReleasesGetInstanceFieldsGameCenterChallengeVersionRelease? ToEnum(string value)
        {
            return value switch
            {
                "version" => GameCenterChallengeVersionReleasesGetInstanceFieldsGameCenterChallengeVersionRelease.Version,
                _ => null,
            };
        }
    }
}