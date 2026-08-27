
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingRuleSetRelationshipsRulesDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterMatchmakingRules,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingRuleSetRelationshipsRulesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleSetRelationshipsRulesDataItemType value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleSetRelationshipsRulesDataItemType.GameCenterMatchmakingRules => "gameCenterMatchmakingRules",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleSetRelationshipsRulesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingRules" => GameCenterMatchmakingRuleSetRelationshipsRulesDataItemType.GameCenterMatchmakingRules,
                _ => null,
            };
        }
    }
}