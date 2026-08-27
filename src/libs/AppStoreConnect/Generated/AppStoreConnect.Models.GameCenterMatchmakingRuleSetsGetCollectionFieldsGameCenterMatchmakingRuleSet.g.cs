
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet
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
    public static class GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet.MatchmakingQueues => "matchmakingQueues",
                GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet.MaxPlayers => "maxPlayers",
                GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet.MinPlayers => "minPlayers",
                GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet.ReferenceName => "referenceName",
                GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet.RuleLanguageVersion => "ruleLanguageVersion",
                GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet.Rules => "rules",
                GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet.Teams => "teams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet? ToEnum(string value)
        {
            return value switch
            {
                "matchmakingQueues" => GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet.MatchmakingQueues,
                "maxPlayers" => GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet.MaxPlayers,
                "minPlayers" => GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet.MinPlayers,
                "referenceName" => GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet.ReferenceName,
                "ruleLanguageVersion" => GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet.RuleLanguageVersion,
                "rules" => GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet.Rules,
                "teams" => GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet.Teams,
                _ => null,
            };
        }
    }
}