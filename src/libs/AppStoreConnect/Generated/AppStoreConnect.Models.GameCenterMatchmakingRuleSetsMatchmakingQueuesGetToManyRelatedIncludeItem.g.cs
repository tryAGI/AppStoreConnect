
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedIncludeItem
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
    public static class GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedIncludeItem.ExperimentRuleSet => "experimentRuleSet",
                GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedIncludeItem.RuleSet => "ruleSet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "experimentRuleSet" => GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedIncludeItem.ExperimentRuleSet,
                "ruleSet" => GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedIncludeItem.RuleSet,
                _ => null,
            };
        }
    }
}