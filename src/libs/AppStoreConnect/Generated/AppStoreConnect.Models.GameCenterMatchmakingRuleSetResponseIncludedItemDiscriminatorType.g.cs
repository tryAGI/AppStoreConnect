
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingRuleSetResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterMatchmakingQueues,
        /// <summary>
        /// 
        /// </summary>
        GameCenterMatchmakingRules,
        /// <summary>
        /// 
        /// </summary>
        GameCenterMatchmakingTeams,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingRuleSetResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleSetResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleSetResponseIncludedItemDiscriminatorType.GameCenterMatchmakingQueues => "gameCenterMatchmakingQueues",
                GameCenterMatchmakingRuleSetResponseIncludedItemDiscriminatorType.GameCenterMatchmakingRules => "gameCenterMatchmakingRules",
                GameCenterMatchmakingRuleSetResponseIncludedItemDiscriminatorType.GameCenterMatchmakingTeams => "gameCenterMatchmakingTeams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleSetResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingQueues" => GameCenterMatchmakingRuleSetResponseIncludedItemDiscriminatorType.GameCenterMatchmakingQueues,
                "gameCenterMatchmakingRules" => GameCenterMatchmakingRuleSetResponseIncludedItemDiscriminatorType.GameCenterMatchmakingRules,
                "gameCenterMatchmakingTeams" => GameCenterMatchmakingRuleSetResponseIncludedItemDiscriminatorType.GameCenterMatchmakingTeams,
                _ => null,
            };
        }
    }
}