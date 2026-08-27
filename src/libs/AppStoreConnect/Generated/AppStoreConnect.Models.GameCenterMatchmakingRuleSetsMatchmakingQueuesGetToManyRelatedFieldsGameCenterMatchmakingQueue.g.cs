
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingQueue
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
    public static class GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingQueueExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingQueue value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingQueue.ClassicMatchmakingBundleIds => "classicMatchmakingBundleIds",
                GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingQueue.ExperimentRuleSet => "experimentRuleSet",
                GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingQueue.ReferenceName => "referenceName",
                GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingQueue.RuleSet => "ruleSet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingQueue? ToEnum(string value)
        {
            return value switch
            {
                "classicMatchmakingBundleIds" => GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingQueue.ClassicMatchmakingBundleIds,
                "experimentRuleSet" => GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingQueue.ExperimentRuleSet,
                "referenceName" => GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingQueue.ReferenceName,
                "ruleSet" => GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingQueue.RuleSet,
                _ => null,
            };
        }
    }
}