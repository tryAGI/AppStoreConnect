
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardGroupLeaderboardLinkageRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboards,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardGroupLeaderboardLinkageRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardGroupLeaderboardLinkageRequestDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardGroupLeaderboardLinkageRequestDataType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardGroupLeaderboardLinkageRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboards" => GameCenterLeaderboardGroupLeaderboardLinkageRequestDataType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}