
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterMatchmakingQueues,
        /// <summary>
        ///
        /// </summary>
        GameCenterMatchmakingRules,
        /// <summary>
        ///
        /// </summary>
        GameCenterMatchmakingTeams,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminatorType.GameCenterMatchmakingQueues => "gameCenterMatchmakingQueues",
                GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminatorType.GameCenterMatchmakingRules => "gameCenterMatchmakingRules",
                GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminatorType.GameCenterMatchmakingTeams => "gameCenterMatchmakingTeams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingQueues" => GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminatorType.GameCenterMatchmakingQueues,
                "gameCenterMatchmakingRules" => GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminatorType.GameCenterMatchmakingRules,
                "gameCenterMatchmakingTeams" => GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminatorType.GameCenterMatchmakingTeams,
                _ => null,
            };
        }
    }
}