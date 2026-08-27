
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingTeamUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterMatchmakingTeams,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingTeamUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingTeamUpdateRequestDataType value)
        {
            return value switch
            {
                GameCenterMatchmakingTeamUpdateRequestDataType.GameCenterMatchmakingTeams => "gameCenterMatchmakingTeams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingTeamUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingTeams" => GameCenterMatchmakingTeamUpdateRequestDataType.GameCenterMatchmakingTeams,
                _ => null,
            };
        }
    }
}