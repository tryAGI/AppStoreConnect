
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingRuleType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterMatchmakingRules,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingRuleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleType value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleType.GameCenterMatchmakingRules => "gameCenterMatchmakingRules",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingRules" => GameCenterMatchmakingRuleType.GameCenterMatchmakingRules,
                _ => null,
            };
        }
    }
}