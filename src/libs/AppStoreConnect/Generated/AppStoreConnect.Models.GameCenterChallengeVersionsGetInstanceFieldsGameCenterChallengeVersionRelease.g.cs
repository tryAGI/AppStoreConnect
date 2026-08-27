
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeVersionRelease
    {
        /// <summary>
        ///
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeVersionReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeVersionRelease value)
        {
            return value switch
            {
                GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeVersionRelease.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeVersionRelease? ToEnum(string value)
        {
            return value switch
            {
                "version" => GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeVersionRelease.Version,
                _ => null,
            };
        }
    }
}