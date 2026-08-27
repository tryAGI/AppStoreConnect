
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingQueue
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
    public static class GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingQueueExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingQueue value)
        {
            return value switch
            {
                GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingQueue.ClassicMatchmakingBundleIds => "classicMatchmakingBundleIds",
                GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingQueue.ExperimentRuleSet => "experimentRuleSet",
                GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingQueue.ReferenceName => "referenceName",
                GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingQueue.RuleSet => "ruleSet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingQueue? ToEnum(string value)
        {
            return value switch
            {
                "classicMatchmakingBundleIds" => GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingQueue.ClassicMatchmakingBundleIds,
                "experimentRuleSet" => GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingQueue.ExperimentRuleSet,
                "referenceName" => GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingQueue.ReferenceName,
                "ruleSet" => GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingQueue.RuleSet,
                _ => null,
            };
        }
    }
}