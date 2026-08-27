
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersionRelease
    {
        /// <summary>
        /// 
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersionReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersionRelease value)
        {
            return value switch
            {
                GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersionRelease.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersionRelease? ToEnum(string value)
        {
            return value switch
            {
                "version" => GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersionRelease.Version,
                _ => null,
            };
        }
    }
}