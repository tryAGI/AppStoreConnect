
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingRuleSetRulesLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterMatchmakingRules,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingRuleSetRulesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleSetRulesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleSetRulesLinkagesResponseDataItemType.GameCenterMatchmakingRules => "gameCenterMatchmakingRules",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleSetRulesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingRules" => GameCenterMatchmakingRuleSetRulesLinkagesResponseDataItemType.GameCenterMatchmakingRules,
                _ => null,
            };
        }
    }
}