
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterGroupRelationshipsGameCenterChallengesDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterChallenges,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterGroupRelationshipsGameCenterChallengesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupRelationshipsGameCenterChallengesDataItemType value)
        {
            return value switch
            {
                GameCenterGroupRelationshipsGameCenterChallengesDataItemType.GameCenterChallenges => "gameCenterChallenges",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupRelationshipsGameCenterChallengesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallenges" => GameCenterGroupRelationshipsGameCenterChallengesDataItemType.GameCenterChallenges,
                _ => null,
            };
        }
    }
}