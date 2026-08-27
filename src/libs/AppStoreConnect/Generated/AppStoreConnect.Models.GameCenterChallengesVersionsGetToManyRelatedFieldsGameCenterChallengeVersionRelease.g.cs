
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersionRelease
    {
        /// <summary>
        ///
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersionReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersionRelease value)
        {
            return value switch
            {
                GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersionRelease.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersionRelease? ToEnum(string value)
        {
            return value switch
            {
                "version" => GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersionRelease.Version,
                _ => null,
            };
        }
    }
}