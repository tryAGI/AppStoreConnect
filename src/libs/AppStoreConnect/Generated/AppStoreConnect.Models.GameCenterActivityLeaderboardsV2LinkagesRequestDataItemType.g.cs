
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterActivityLeaderboardsV2LinkagesRequestDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboards,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityLeaderboardsV2LinkagesRequestDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityLeaderboardsV2LinkagesRequestDataItemType value)
        {
            return value switch
            {
                GameCenterActivityLeaderboardsV2LinkagesRequestDataItemType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityLeaderboardsV2LinkagesRequestDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboards" => GameCenterActivityLeaderboardsV2LinkagesRequestDataItemType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}