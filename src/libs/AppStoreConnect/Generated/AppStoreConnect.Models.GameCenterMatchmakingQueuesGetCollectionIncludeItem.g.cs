
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingQueuesGetCollectionIncludeItem
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
    public static class GameCenterMatchmakingQueuesGetCollectionIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingQueuesGetCollectionIncludeItem value)
        {
            return value switch
            {
                GameCenterMatchmakingQueuesGetCollectionIncludeItem.ExperimentRuleSet => "experimentRuleSet",
                GameCenterMatchmakingQueuesGetCollectionIncludeItem.RuleSet => "ruleSet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingQueuesGetCollectionIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "experimentRuleSet" => GameCenterMatchmakingQueuesGetCollectionIncludeItem.ExperimentRuleSet,
                "ruleSet" => GameCenterMatchmakingQueuesGetCollectionIncludeItem.RuleSet,
                _ => null,
            };
        }
    }
}