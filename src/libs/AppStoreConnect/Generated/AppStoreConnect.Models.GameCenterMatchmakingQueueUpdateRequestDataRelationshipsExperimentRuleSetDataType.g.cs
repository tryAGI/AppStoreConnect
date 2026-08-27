
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingQueueUpdateRequestDataRelationshipsExperimentRuleSetDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterMatchmakingRuleSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingQueueUpdateRequestDataRelationshipsExperimentRuleSetDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingQueueUpdateRequestDataRelationshipsExperimentRuleSetDataType value)
        {
            return value switch
            {
                GameCenterMatchmakingQueueUpdateRequestDataRelationshipsExperimentRuleSetDataType.GameCenterMatchmakingRuleSets => "gameCenterMatchmakingRuleSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingQueueUpdateRequestDataRelationshipsExperimentRuleSetDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingRuleSets" => GameCenterMatchmakingQueueUpdateRequestDataRelationshipsExperimentRuleSetDataType.GameCenterMatchmakingRuleSets,
                _ => null,
            };
        }
    }
}