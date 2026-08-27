
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingQueuesGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        ExperimentRuleSet,
        /// <summary>
        /// 
        /// </summary>
        RuleSet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingQueuesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingQueuesGetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterMatchmakingQueuesGetInstanceIncludeItem.ExperimentRuleSet => "experimentRuleSet",
                GameCenterMatchmakingQueuesGetInstanceIncludeItem.RuleSet => "ruleSet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingQueuesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "experimentRuleSet" => GameCenterMatchmakingQueuesGetInstanceIncludeItem.ExperimentRuleSet,
                "ruleSet" => GameCenterMatchmakingQueuesGetInstanceIncludeItem.RuleSet,
                _ => null,
            };
        }
    }
}