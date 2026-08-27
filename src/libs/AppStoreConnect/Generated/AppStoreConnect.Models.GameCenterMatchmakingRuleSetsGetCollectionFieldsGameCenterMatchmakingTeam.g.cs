
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeam
    {
        /// <summary>
        /// 
        /// </summary>
        MaxPlayers,
        /// <summary>
        /// 
        /// </summary>
        MinPlayers,
        /// <summary>
        /// 
        /// </summary>
        ReferenceName,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeamExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeam value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeam.MaxPlayers => "maxPlayers",
                GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeam.MinPlayers => "minPlayers",
                GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeam.ReferenceName => "referenceName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeam? ToEnum(string value)
        {
            return value switch
            {
                "maxPlayers" => GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeam.MaxPlayers,
                "minPlayers" => GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeam.MinPlayers,
                "referenceName" => GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeam.ReferenceName,
                _ => null,
            };
        }
    }
}