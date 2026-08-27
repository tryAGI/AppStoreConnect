
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterChallengeVersionReleaseCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterChallengeVersionReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeVersionReleaseCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeVersionReleaseCreateRequestDataType value)
        {
            return value switch
            {
                GameCenterChallengeVersionReleaseCreateRequestDataType.GameCenterChallengeVersionReleases => "gameCenterChallengeVersionReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeVersionReleaseCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallengeVersionReleases" => GameCenterChallengeVersionReleaseCreateRequestDataType.GameCenterChallengeVersionReleases,
                _ => null,
            };
        }
    }
}