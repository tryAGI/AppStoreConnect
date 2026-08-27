
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingRuleSetUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterMatchmakingRuleSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingRuleSetUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleSetUpdateRequestDataType value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleSetUpdateRequestDataType.GameCenterMatchmakingRuleSets => "gameCenterMatchmakingRuleSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleSetUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingRuleSets" => GameCenterMatchmakingRuleSetUpdateRequestDataType.GameCenterMatchmakingRuleSets,
                _ => null,
            };
        }
    }
}