
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetRelationshipsReleasesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSetReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetRelationshipsReleasesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetRelationshipsReleasesDataItemType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetRelationshipsReleasesDataItemType.GameCenterLeaderboardSetReleases => "gameCenterLeaderboardSetReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetRelationshipsReleasesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSetReleases" => GameCenterLeaderboardSetRelationshipsReleasesDataItemType.GameCenterLeaderboardSetReleases,
                _ => null,
            };
        }
    }
}