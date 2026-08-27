
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingRuleSetTestType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterMatchmakingRuleSetTests,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingRuleSetTestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleSetTestType value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleSetTestType.GameCenterMatchmakingRuleSetTests => "gameCenterMatchmakingRuleSetTests",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleSetTestType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingRuleSetTests" => GameCenterMatchmakingRuleSetTestType.GameCenterMatchmakingRuleSetTests,
                _ => null,
            };
        }
    }
}