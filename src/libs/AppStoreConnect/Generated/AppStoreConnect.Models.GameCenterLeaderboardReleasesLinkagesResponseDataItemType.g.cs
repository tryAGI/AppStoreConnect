
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardReleasesLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardReleasesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardReleasesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                GameCenterLeaderboardReleasesLinkagesResponseDataItemType.GameCenterLeaderboardReleases => "gameCenterLeaderboardReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardReleasesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardReleases" => GameCenterLeaderboardReleasesLinkagesResponseDataItemType.GameCenterLeaderboardReleases,
                _ => null,
            };
        }
    }
}