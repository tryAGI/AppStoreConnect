
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterMatchmakingQueues,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItemType value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItemType.GameCenterMatchmakingQueues => "gameCenterMatchmakingQueues",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingQueues" => GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItemType.GameCenterMatchmakingQueues,
                _ => null,
            };
        }
    }
}