
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingRuleSetsGetCollectionIncludeItem
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
    public static class GameCenterMatchmakingRuleSetsGetCollectionIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleSetsGetCollectionIncludeItem value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleSetsGetCollectionIncludeItem.MatchmakingQueues => "matchmakingQueues",
                GameCenterMatchmakingRuleSetsGetCollectionIncludeItem.Rules => "rules",
                GameCenterMatchmakingRuleSetsGetCollectionIncludeItem.Teams => "teams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleSetsGetCollectionIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "matchmakingQueues" => GameCenterMatchmakingRuleSetsGetCollectionIncludeItem.MatchmakingQueues,
                "rules" => GameCenterMatchmakingRuleSetsGetCollectionIncludeItem.Rules,
                "teams" => GameCenterMatchmakingRuleSetsGetCollectionIncludeItem.Teams,
                _ => null,
            };
        }
    }
}