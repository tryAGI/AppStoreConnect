
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailLeaderboardReleasesLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailLeaderboardReleasesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailLeaderboardReleasesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                GameCenterDetailLeaderboardReleasesLinkagesResponseDataItemType.GameCenterLeaderboardReleases => "gameCenterLeaderboardReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailLeaderboardReleasesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardReleases" => GameCenterDetailLeaderboardReleasesLinkagesResponseDataItemType.GameCenterLeaderboardReleases,
                _ => null,
            };
        }
    }
}