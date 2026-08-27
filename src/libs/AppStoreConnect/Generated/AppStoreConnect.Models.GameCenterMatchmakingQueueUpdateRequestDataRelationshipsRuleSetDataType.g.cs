
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingQueueUpdateRequestDataRelationshipsRuleSetDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterMatchmakingRuleSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingQueueUpdateRequestDataRelationshipsRuleSetDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingQueueUpdateRequestDataRelationshipsRuleSetDataType value)
        {
            return value switch
            {
                GameCenterMatchmakingQueueUpdateRequestDataRelationshipsRuleSetDataType.GameCenterMatchmakingRuleSets => "gameCenterMatchmakingRuleSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingQueueUpdateRequestDataRelationshipsRuleSetDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingRuleSets" => GameCenterMatchmakingQueueUpdateRequestDataRelationshipsRuleSetDataType.GameCenterMatchmakingRuleSets,
                _ => null,
            };
        }
    }
}