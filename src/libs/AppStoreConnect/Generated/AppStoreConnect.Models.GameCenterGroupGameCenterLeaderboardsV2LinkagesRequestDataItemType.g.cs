
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupGameCenterLeaderboardsV2LinkagesRequestDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboards,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterGroupGameCenterLeaderboardsV2LinkagesRequestDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupGameCenterLeaderboardsV2LinkagesRequestDataItemType value)
        {
            return value switch
            {
                GameCenterGroupGameCenterLeaderboardsV2LinkagesRequestDataItemType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupGameCenterLeaderboardsV2LinkagesRequestDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboards" => GameCenterGroupGameCenterLeaderboardsV2LinkagesRequestDataItemType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}