
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingRuleSetTeamsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterMatchmakingTeams,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingRuleSetTeamsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleSetTeamsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleSetTeamsLinkagesResponseDataItemType.GameCenterMatchmakingTeams => "gameCenterMatchmakingTeams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleSetTeamsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingTeams" => GameCenterMatchmakingRuleSetTeamsLinkagesResponseDataItemType.GameCenterMatchmakingTeams,
                _ => null,
            };
        }
    }
}