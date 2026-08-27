
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingRuleSetsRulesGetToManyRelatedFieldsGameCenterMatchmakingRule
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
    public static class GameCenterMatchmakingRuleSetsRulesGetToManyRelatedFieldsGameCenterMatchmakingRuleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleSetsRulesGetToManyRelatedFieldsGameCenterMatchmakingRule value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleSetsRulesGetToManyRelatedFieldsGameCenterMatchmakingRule.Description => "description",
                GameCenterMatchmakingRuleSetsRulesGetToManyRelatedFieldsGameCenterMatchmakingRule.Expression => "expression",
                GameCenterMatchmakingRuleSetsRulesGetToManyRelatedFieldsGameCenterMatchmakingRule.ReferenceName => "referenceName",
                GameCenterMatchmakingRuleSetsRulesGetToManyRelatedFieldsGameCenterMatchmakingRule.Type => "type",
                GameCenterMatchmakingRuleSetsRulesGetToManyRelatedFieldsGameCenterMatchmakingRule.Weight => "weight",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleSetsRulesGetToManyRelatedFieldsGameCenterMatchmakingRule? ToEnum(string value)
        {
            return value switch
            {
                "description" => GameCenterMatchmakingRuleSetsRulesGetToManyRelatedFieldsGameCenterMatchmakingRule.Description,
                "expression" => GameCenterMatchmakingRuleSetsRulesGetToManyRelatedFieldsGameCenterMatchmakingRule.Expression,
                "referenceName" => GameCenterMatchmakingRuleSetsRulesGetToManyRelatedFieldsGameCenterMatchmakingRule.ReferenceName,
                "type" => GameCenterMatchmakingRuleSetsRulesGetToManyRelatedFieldsGameCenterMatchmakingRule.Type,
                "weight" => GameCenterMatchmakingRuleSetsRulesGetToManyRelatedFieldsGameCenterMatchmakingRule.Weight,
                _ => null,
            };
        }
    }
}