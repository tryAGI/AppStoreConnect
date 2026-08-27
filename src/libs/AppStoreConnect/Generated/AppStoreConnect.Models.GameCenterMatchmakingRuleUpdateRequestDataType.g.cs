
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingRuleUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterMatchmakingRules,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingRuleUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleUpdateRequestDataType value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleUpdateRequestDataType.GameCenterMatchmakingRules => "gameCenterMatchmakingRules",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingRules" => GameCenterMatchmakingRuleUpdateRequestDataType.GameCenterMatchmakingRules,
                _ => null,
            };
        }
    }
}