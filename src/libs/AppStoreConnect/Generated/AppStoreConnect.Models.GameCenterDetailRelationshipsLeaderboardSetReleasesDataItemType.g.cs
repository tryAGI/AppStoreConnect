
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardSetReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemType value)
        {
            return value switch
            {
                GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemType.GameCenterLeaderboardSetReleases => "gameCenterLeaderboardSetReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSetReleases" => GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemType.GameCenterLeaderboardSetReleases,
                _ => null,
            };
        }
    }
}