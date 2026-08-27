
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingRuleSetTestCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterMatchmakingRuleSetTests,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingRuleSetTestCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleSetTestCreateRequestDataType value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleSetTestCreateRequestDataType.GameCenterMatchmakingRuleSetTests => "gameCenterMatchmakingRuleSetTests",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleSetTestCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingRuleSetTests" => GameCenterMatchmakingRuleSetTestCreateRequestDataType.GameCenterMatchmakingRuleSetTests,
                _ => null,
            };
        }
    }
}