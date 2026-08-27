
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingTeamType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterMatchmakingTeams,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingTeamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingTeamType value)
        {
            return value switch
            {
                GameCenterMatchmakingTeamType.GameCenterMatchmakingTeams => "gameCenterMatchmakingTeams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingTeamType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingTeams" => GameCenterMatchmakingTeamType.GameCenterMatchmakingTeams,
                _ => null,
            };
        }
    }
}