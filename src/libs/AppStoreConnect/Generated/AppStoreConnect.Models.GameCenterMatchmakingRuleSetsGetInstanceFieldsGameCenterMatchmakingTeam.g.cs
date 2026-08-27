
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeam
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
    public static class GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeamExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeam value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeam.MaxPlayers => "maxPlayers",
                GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeam.MinPlayers => "minPlayers",
                GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeam.ReferenceName => "referenceName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeam? ToEnum(string value)
        {
            return value switch
            {
                "maxPlayers" => GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeam.MaxPlayers,
                "minPlayers" => GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeam.MinPlayers,
                "referenceName" => GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeam.ReferenceName,
                _ => null,
            };
        }
    }
}