
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingQueue
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
    public static class GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingQueueExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingQueue value)
        {
            return value switch
            {
                GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingQueue.ClassicMatchmakingBundleIds => "classicMatchmakingBundleIds",
                GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingQueue.ExperimentRuleSet => "experimentRuleSet",
                GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingQueue.ReferenceName => "referenceName",
                GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingQueue.RuleSet => "ruleSet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingQueue? ToEnum(string value)
        {
            return value switch
            {
                "classicMatchmakingBundleIds" => GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingQueue.ClassicMatchmakingBundleIds,
                "experimentRuleSet" => GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingQueue.ExperimentRuleSet,
                "referenceName" => GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingQueue.ReferenceName,
                "ruleSet" => GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingQueue.RuleSet,
                _ => null,
            };
        }
    }
}