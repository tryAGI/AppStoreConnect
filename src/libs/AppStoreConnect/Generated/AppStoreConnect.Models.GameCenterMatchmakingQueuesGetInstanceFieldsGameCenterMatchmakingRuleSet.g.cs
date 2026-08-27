
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingRuleSet
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
    public static class GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingRuleSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingRuleSet value)
        {
            return value switch
            {
                GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingRuleSet.MatchmakingQueues => "matchmakingQueues",
                GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingRuleSet.MaxPlayers => "maxPlayers",
                GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingRuleSet.MinPlayers => "minPlayers",
                GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingRuleSet.ReferenceName => "referenceName",
                GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingRuleSet.RuleLanguageVersion => "ruleLanguageVersion",
                GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingRuleSet.Rules => "rules",
                GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingRuleSet.Teams => "teams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingRuleSet? ToEnum(string value)
        {
            return value switch
            {
                "matchmakingQueues" => GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingRuleSet.MatchmakingQueues,
                "maxPlayers" => GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingRuleSet.MaxPlayers,
                "minPlayers" => GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingRuleSet.MinPlayers,
                "referenceName" => GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingRuleSet.ReferenceName,
                "ruleLanguageVersion" => GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingRuleSet.RuleLanguageVersion,
                "rules" => GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingRuleSet.Rules,
                "teams" => GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingRuleSet.Teams,
                _ => null,
            };
        }
    }
}