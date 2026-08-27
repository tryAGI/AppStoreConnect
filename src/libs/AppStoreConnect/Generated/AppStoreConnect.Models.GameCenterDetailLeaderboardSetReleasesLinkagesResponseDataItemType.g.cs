
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailLeaderboardSetReleasesLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSetReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailLeaderboardSetReleasesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailLeaderboardSetReleasesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                GameCenterDetailLeaderboardSetReleasesLinkagesResponseDataItemType.GameCenterLeaderboardSetReleases => "gameCenterLeaderboardSetReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailLeaderboardSetReleasesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSetReleases" => GameCenterDetailLeaderboardSetReleasesLinkagesResponseDataItemType.GameCenterLeaderboardSetReleases,
                _ => null,
            };
        }
    }
}