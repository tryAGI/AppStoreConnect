
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingQueueCreateRequestDataRelationshipsExperimentRuleSetDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterMatchmakingRuleSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingQueueCreateRequestDataRelationshipsExperimentRuleSetDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingQueueCreateRequestDataRelationshipsExperimentRuleSetDataType value)
        {
            return value switch
            {
                GameCenterMatchmakingQueueCreateRequestDataRelationshipsExperimentRuleSetDataType.GameCenterMatchmakingRuleSets => "gameCenterMatchmakingRuleSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingQueueCreateRequestDataRelationshipsExperimentRuleSetDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingRuleSets" => GameCenterMatchmakingQueueCreateRequestDataRelationshipsExperimentRuleSetDataType.GameCenterMatchmakingRuleSets,
                _ => null,
            };
        }
    }
}