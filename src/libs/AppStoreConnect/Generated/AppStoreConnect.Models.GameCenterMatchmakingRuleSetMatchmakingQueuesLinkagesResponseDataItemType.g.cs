
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingRuleSetMatchmakingQueuesLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterMatchmakingQueues,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingRuleSetMatchmakingQueuesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleSetMatchmakingQueuesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleSetMatchmakingQueuesLinkagesResponseDataItemType.GameCenterMatchmakingQueues => "gameCenterMatchmakingQueues",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleSetMatchmakingQueuesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingQueues" => GameCenterMatchmakingRuleSetMatchmakingQueuesLinkagesResponseDataItemType.GameCenterMatchmakingQueues,
                _ => null,
            };
        }
    }
}