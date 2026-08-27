
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule
    {
        /// <summary>
        /// 
        /// </summary>
        Description,
        /// <summary>
        /// 
        /// </summary>
        Expression,
        /// <summary>
        /// 
        /// </summary>
        ReferenceName,
        /// <summary>
        /// 
        /// </summary>
        Type,
        /// <summary>
        /// 
        /// </summary>
        Weight,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule.Description => "description",
                GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule.Expression => "expression",
                GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule.ReferenceName => "referenceName",
                GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule.Type => "type",
                GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule.Weight => "weight",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule? ToEnum(string value)
        {
            return value switch
            {
                "description" => GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule.Description,
                "expression" => GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule.Expression,
                "referenceName" => GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule.ReferenceName,
                "type" => GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule.Type,
                "weight" => GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule.Weight,
                _ => null,
            };
        }
    }
}