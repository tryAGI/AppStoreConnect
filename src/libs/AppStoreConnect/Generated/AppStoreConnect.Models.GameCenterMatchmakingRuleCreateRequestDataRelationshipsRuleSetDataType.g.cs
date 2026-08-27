
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingRuleCreateRequestDataRelationshipsRuleSetDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterMatchmakingRuleSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingRuleCreateRequestDataRelationshipsRuleSetDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleCreateRequestDataRelationshipsRuleSetDataType value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleCreateRequestDataRelationshipsRuleSetDataType.GameCenterMatchmakingRuleSets => "gameCenterMatchmakingRuleSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleCreateRequestDataRelationshipsRuleSetDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingRuleSets" => GameCenterMatchmakingRuleCreateRequestDataRelationshipsRuleSetDataType.GameCenterMatchmakingRuleSets,
                _ => null,
            };
        }
    }
}