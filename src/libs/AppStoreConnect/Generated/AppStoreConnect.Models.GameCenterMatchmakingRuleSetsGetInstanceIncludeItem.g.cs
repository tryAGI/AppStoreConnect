
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingRuleSetsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        MatchmakingQueues,
        /// <summary>
        ///
        /// </summary>
        Rules,
        /// <summary>
        ///
        /// </summary>
        Teams,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingRuleSetsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleSetsGetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleSetsGetInstanceIncludeItem.MatchmakingQueues => "matchmakingQueues",
                GameCenterMatchmakingRuleSetsGetInstanceIncludeItem.Rules => "rules",
                GameCenterMatchmakingRuleSetsGetInstanceIncludeItem.Teams => "teams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleSetsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "matchmakingQueues" => GameCenterMatchmakingRuleSetsGetInstanceIncludeItem.MatchmakingQueues,
                "rules" => GameCenterMatchmakingRuleSetsGetInstanceIncludeItem.Rules,
                "teams" => GameCenterMatchmakingRuleSetsGetInstanceIncludeItem.Teams,
                _ => null,
            };
        }
    }
}