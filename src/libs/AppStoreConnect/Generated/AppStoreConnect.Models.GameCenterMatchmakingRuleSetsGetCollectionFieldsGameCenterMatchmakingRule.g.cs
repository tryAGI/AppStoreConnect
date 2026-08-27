
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule
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
    public static class GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule.Description => "description",
                GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule.Expression => "expression",
                GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule.ReferenceName => "referenceName",
                GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule.Type => "type",
                GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule.Weight => "weight",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule? ToEnum(string value)
        {
            return value switch
            {
                "description" => GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule.Description,
                "expression" => GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule.Expression,
                "referenceName" => GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule.ReferenceName,
                "type" => GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule.Type,
                "weight" => GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule.Weight,
                _ => null,
            };
        }
    }
}