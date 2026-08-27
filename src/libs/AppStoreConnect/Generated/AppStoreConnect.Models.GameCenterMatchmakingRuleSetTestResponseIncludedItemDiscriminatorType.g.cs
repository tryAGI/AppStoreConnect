
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingRuleSetTestResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterMatchmakingTestPlayerProperties,
        /// <summary>
        ///
        /// </summary>
        GameCenterMatchmakingTestRequests,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingRuleSetTestResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleSetTestResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleSetTestResponseIncludedItemDiscriminatorType.GameCenterMatchmakingTestPlayerProperties => "gameCenterMatchmakingTestPlayerProperties",
                GameCenterMatchmakingRuleSetTestResponseIncludedItemDiscriminatorType.GameCenterMatchmakingTestRequests => "gameCenterMatchmakingTestRequests",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleSetTestResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingTestPlayerProperties" => GameCenterMatchmakingRuleSetTestResponseIncludedItemDiscriminatorType.GameCenterMatchmakingTestPlayerProperties,
                "gameCenterMatchmakingTestRequests" => GameCenterMatchmakingRuleSetTestResponseIncludedItemDiscriminatorType.GameCenterMatchmakingTestRequests,
                _ => null,
            };
        }
    }
}