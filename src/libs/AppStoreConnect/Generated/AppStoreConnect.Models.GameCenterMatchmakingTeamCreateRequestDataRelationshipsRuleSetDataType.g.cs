
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingTeamCreateRequestDataRelationshipsRuleSetDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterMatchmakingRuleSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingTeamCreateRequestDataRelationshipsRuleSetDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingTeamCreateRequestDataRelationshipsRuleSetDataType value)
        {
            return value switch
            {
                GameCenterMatchmakingTeamCreateRequestDataRelationshipsRuleSetDataType.GameCenterMatchmakingRuleSets => "gameCenterMatchmakingRuleSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingTeamCreateRequestDataRelationshipsRuleSetDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingRuleSets" => GameCenterMatchmakingTeamCreateRequestDataRelationshipsRuleSetDataType.GameCenterMatchmakingRuleSets,
                _ => null,
            };
        }
    }
}