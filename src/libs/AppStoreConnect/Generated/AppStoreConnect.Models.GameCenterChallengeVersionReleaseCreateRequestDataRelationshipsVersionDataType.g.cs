
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterChallengeVersionReleaseCreateRequestDataRelationshipsVersionDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterChallengeVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeVersionReleaseCreateRequestDataRelationshipsVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeVersionReleaseCreateRequestDataRelationshipsVersionDataType value)
        {
            return value switch
            {
                GameCenterChallengeVersionReleaseCreateRequestDataRelationshipsVersionDataType.GameCenterChallengeVersions => "gameCenterChallengeVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeVersionReleaseCreateRequestDataRelationshipsVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallengeVersions" => GameCenterChallengeVersionReleaseCreateRequestDataRelationshipsVersionDataType.GameCenterChallengeVersions,
                _ => null,
            };
        }
    }
}