
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetVersionV2Type
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardSetVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetVersionV2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetVersionV2Type value)
        {
            return value switch
            {
                GameCenterLeaderboardSetVersionV2Type.GameCenterLeaderboardSetVersions => "gameCenterLeaderboardSetVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetVersionV2Type? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSetVersions" => GameCenterLeaderboardSetVersionV2Type.GameCenterLeaderboardSetVersions,
                _ => null,
            };
        }
    }
}