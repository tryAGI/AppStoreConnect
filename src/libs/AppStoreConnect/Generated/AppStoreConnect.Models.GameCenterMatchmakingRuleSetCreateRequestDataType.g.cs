
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingRuleSetCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterMatchmakingRuleSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingRuleSetCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleSetCreateRequestDataType value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleSetCreateRequestDataType.GameCenterMatchmakingRuleSets => "gameCenterMatchmakingRuleSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleSetCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingRuleSets" => GameCenterMatchmakingRuleSetCreateRequestDataType.GameCenterMatchmakingRuleSets,
                _ => null,
            };
        }
    }
}