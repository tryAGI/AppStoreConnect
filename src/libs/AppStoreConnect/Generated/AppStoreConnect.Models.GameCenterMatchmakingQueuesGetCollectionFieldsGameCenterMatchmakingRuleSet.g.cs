
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSet
    {
        /// <summary>
        /// 
        /// </summary>
        MatchmakingQueues,
        /// <summary>
        /// 
        /// </summary>
        MaxPlayers,
        /// <summary>
        /// 
        /// </summary>
        MinPlayers,
        /// <summary>
        /// 
        /// </summary>
        ReferenceName,
        /// <summary>
        /// 
        /// </summary>
        RuleLanguageVersion,
        /// <summary>
        /// 
        /// </summary>
        Rules,
        /// <summary>
        /// 
        /// </summary>
        Teams,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSet value)
        {
            return value switch
            {
                GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSet.MatchmakingQueues => "matchmakingQueues",
                GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSet.MaxPlayers => "maxPlayers",
                GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSet.MinPlayers => "minPlayers",
                GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSet.ReferenceName => "referenceName",
                GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSet.RuleLanguageVersion => "ruleLanguageVersion",
                GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSet.Rules => "rules",
                GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSet.Teams => "teams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSet? ToEnum(string value)
        {
            return value switch
            {
                "matchmakingQueues" => GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSet.MatchmakingQueues,
                "maxPlayers" => GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSet.MaxPlayers,
                "minPlayers" => GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSet.MinPlayers,
                "referenceName" => GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSet.ReferenceName,
                "ruleLanguageVersion" => GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSet.RuleLanguageVersion,
                "rules" => GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSet.Rules,
                "teams" => GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSet.Teams,
                _ => null,
            };
        }
    }
}