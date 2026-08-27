
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRequestsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterMatchmakingTestRequests,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRequestsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRequestsDataItemType value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRequestsDataItemType.GameCenterMatchmakingTestRequests => "gameCenterMatchmakingTestRequests",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRequestsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingTestRequests" => GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRequestsDataItemType.GameCenterMatchmakingTestRequests,
                _ => null,
            };
        }
    }
}