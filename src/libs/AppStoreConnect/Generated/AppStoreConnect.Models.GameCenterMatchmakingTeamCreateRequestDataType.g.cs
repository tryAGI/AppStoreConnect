
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingTeamCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterMatchmakingTeams,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingTeamCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingTeamCreateRequestDataType value)
        {
            return value switch
            {
                GameCenterMatchmakingTeamCreateRequestDataType.GameCenterMatchmakingTeams => "gameCenterMatchmakingTeams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingTeamCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingTeams" => GameCenterMatchmakingTeamCreateRequestDataType.GameCenterMatchmakingTeams,
                _ => null,
            };
        }
    }
}