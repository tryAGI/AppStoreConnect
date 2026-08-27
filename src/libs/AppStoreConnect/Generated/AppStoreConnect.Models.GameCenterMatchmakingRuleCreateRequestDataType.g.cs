
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingRuleCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterMatchmakingRules,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingRuleCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleCreateRequestDataType value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleCreateRequestDataType.GameCenterMatchmakingRules => "gameCenterMatchmakingRules",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingRules" => GameCenterMatchmakingRuleCreateRequestDataType.GameCenterMatchmakingRules,
                _ => null,
            };
        }
    }
}