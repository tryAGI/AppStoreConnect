
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet
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
    public static class GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet.MatchmakingQueues => "matchmakingQueues",
                GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet.MaxPlayers => "maxPlayers",
                GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet.MinPlayers => "minPlayers",
                GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet.ReferenceName => "referenceName",
                GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet.RuleLanguageVersion => "ruleLanguageVersion",
                GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet.Rules => "rules",
                GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet.Teams => "teams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet? ToEnum(string value)
        {
            return value switch
            {
                "matchmakingQueues" => GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet.MatchmakingQueues,
                "maxPlayers" => GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet.MaxPlayers,
                "minPlayers" => GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet.MinPlayers,
                "referenceName" => GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet.ReferenceName,
                "ruleLanguageVersion" => GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet.RuleLanguageVersion,
                "rules" => GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet.Rules,
                "teams" => GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet.Teams,
                _ => null,
            };
        }
    }
}