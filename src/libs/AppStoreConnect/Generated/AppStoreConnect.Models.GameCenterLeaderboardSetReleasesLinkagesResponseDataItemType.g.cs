
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetReleasesLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSetReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetReleasesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetReleasesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetReleasesLinkagesResponseDataItemType.GameCenterLeaderboardSetReleases => "gameCenterLeaderboardSetReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetReleasesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSetReleases" => GameCenterLeaderboardSetReleasesLinkagesResponseDataItemType.GameCenterLeaderboardSetReleases,
                _ => null,
            };
        }
    }
}