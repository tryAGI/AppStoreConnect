
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailRelationshipsLeaderboardReleasesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailRelationshipsLeaderboardReleasesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailRelationshipsLeaderboardReleasesDataItemType value)
        {
            return value switch
            {
                GameCenterDetailRelationshipsLeaderboardReleasesDataItemType.GameCenterLeaderboardReleases => "gameCenterLeaderboardReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailRelationshipsLeaderboardReleasesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardReleases" => GameCenterDetailRelationshipsLeaderboardReleasesDataItemType.GameCenterLeaderboardReleases,
                _ => null,
            };
        }
    }
}