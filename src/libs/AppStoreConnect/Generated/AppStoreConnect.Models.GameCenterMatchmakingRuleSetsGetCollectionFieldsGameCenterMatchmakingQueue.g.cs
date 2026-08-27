
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue
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
    public static class GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueueExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue.ClassicMatchmakingBundleIds => "classicMatchmakingBundleIds",
                GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue.ExperimentRuleSet => "experimentRuleSet",
                GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue.ReferenceName => "referenceName",
                GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue.RuleSet => "ruleSet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue? ToEnum(string value)
        {
            return value switch
            {
                "classicMatchmakingBundleIds" => GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue.ClassicMatchmakingBundleIds,
                "experimentRuleSet" => GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue.ExperimentRuleSet,
                "referenceName" => GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue.ReferenceName,
                "ruleSet" => GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue.RuleSet,
                _ => null,
            };
        }
    }
}