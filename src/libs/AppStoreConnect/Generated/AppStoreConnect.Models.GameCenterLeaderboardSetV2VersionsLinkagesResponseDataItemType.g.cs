
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetV2VersionsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSetVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetV2VersionsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetV2VersionsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetV2VersionsLinkagesResponseDataItemType.GameCenterLeaderboardSetVersions => "gameCenterLeaderboardSetVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetV2VersionsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSetVersions" => GameCenterLeaderboardSetV2VersionsLinkagesResponseDataItemType.GameCenterLeaderboardSetVersions,
                _ => null,
            };
        }
    }
}