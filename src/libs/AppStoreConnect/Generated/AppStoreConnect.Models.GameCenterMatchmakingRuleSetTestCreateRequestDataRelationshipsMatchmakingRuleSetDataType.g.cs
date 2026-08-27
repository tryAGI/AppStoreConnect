
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRuleSetDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterMatchmakingRuleSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRuleSetDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRuleSetDataType value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRuleSetDataType.GameCenterMatchmakingRuleSets => "gameCenterMatchmakingRuleSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRuleSetDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingRuleSets" => GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRuleSetDataType.GameCenterMatchmakingRuleSets,
                _ => null,
            };
        }
    }
}