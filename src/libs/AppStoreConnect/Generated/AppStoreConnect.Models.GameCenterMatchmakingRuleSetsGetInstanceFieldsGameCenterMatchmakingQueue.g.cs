
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue
    {
        /// <summary>
        /// 
        /// </summary>
        ClassicMatchmakingBundleIds,
        /// <summary>
        /// 
        /// </summary>
        ExperimentRuleSet,
        /// <summary>
        /// 
        /// </summary>
        ReferenceName,
        /// <summary>
        /// 
        /// </summary>
        RuleSet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueueExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue.ClassicMatchmakingBundleIds => "classicMatchmakingBundleIds",
                GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue.ExperimentRuleSet => "experimentRuleSet",
                GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue.ReferenceName => "referenceName",
                GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue.RuleSet => "ruleSet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue? ToEnum(string value)
        {
            return value switch
            {
                "classicMatchmakingBundleIds" => GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue.ClassicMatchmakingBundleIds,
                "experimentRuleSet" => GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue.ExperimentRuleSet,
                "referenceName" => GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue.ReferenceName,
                "ruleSet" => GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue.RuleSet,
                _ => null,
            };
        }
    }
}