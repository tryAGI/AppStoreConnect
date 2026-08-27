
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailRelationshipsGameCenterChallengesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterChallenges,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailRelationshipsGameCenterChallengesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailRelationshipsGameCenterChallengesDataItemType value)
        {
            return value switch
            {
                GameCenterDetailRelationshipsGameCenterChallengesDataItemType.GameCenterChallenges => "gameCenterChallenges",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailRelationshipsGameCenterChallengesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallenges" => GameCenterDetailRelationshipsGameCenterChallengesDataItemType.GameCenterChallenges,
                _ => null,
            };
        }
    }
}