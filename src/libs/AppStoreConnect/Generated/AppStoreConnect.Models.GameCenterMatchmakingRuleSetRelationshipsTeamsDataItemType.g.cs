
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingRuleSetRelationshipsTeamsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterMatchmakingTeams,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingRuleSetRelationshipsTeamsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleSetRelationshipsTeamsDataItemType value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleSetRelationshipsTeamsDataItemType.GameCenterMatchmakingTeams => "gameCenterMatchmakingTeams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleSetRelationshipsTeamsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingTeams" => GameCenterMatchmakingRuleSetRelationshipsTeamsDataItemType.GameCenterMatchmakingTeams,
                _ => null,
            };
        }
    }
}