
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengeImageCreateRequestDataRelationshipsVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterChallengeVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeImageCreateRequestDataRelationshipsVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeImageCreateRequestDataRelationshipsVersionDataType value)
        {
            return value switch
            {
                GameCenterChallengeImageCreateRequestDataRelationshipsVersionDataType.GameCenterChallengeVersions => "gameCenterChallengeVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeImageCreateRequestDataRelationshipsVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallengeVersions" => GameCenterChallengeImageCreateRequestDataRelationshipsVersionDataType.GameCenterChallengeVersions,
                _ => null,
            };
        }
    }
}