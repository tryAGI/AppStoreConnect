
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengeCreateRequestDataRelationshipsVersionsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterChallengeVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeCreateRequestDataRelationshipsVersionsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeCreateRequestDataRelationshipsVersionsDataItemType value)
        {
            return value switch
            {
                GameCenterChallengeCreateRequestDataRelationshipsVersionsDataItemType.GameCenterChallengeVersions => "gameCenterChallengeVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeCreateRequestDataRelationshipsVersionsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallengeVersions" => GameCenterChallengeCreateRequestDataRelationshipsVersionsDataItemType.GameCenterChallengeVersions,
                _ => null,
            };
        }
    }
}