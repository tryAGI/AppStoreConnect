
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetGroupLeaderboardSetLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetGroupLeaderboardSetLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetGroupLeaderboardSetLinkageResponseDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetGroupLeaderboardSetLinkageResponseDataType.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetGroupLeaderboardSetLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSets" => GameCenterLeaderboardSetGroupLeaderboardSetLinkageResponseDataType.GameCenterLeaderboardSets,
                _ => null,
            };
        }
    }
}