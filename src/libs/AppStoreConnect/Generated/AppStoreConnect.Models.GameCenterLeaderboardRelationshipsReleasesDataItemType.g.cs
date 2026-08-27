
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardRelationshipsReleasesDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardRelationshipsReleasesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardRelationshipsReleasesDataItemType value)
        {
            return value switch
            {
                GameCenterLeaderboardRelationshipsReleasesDataItemType.GameCenterLeaderboardReleases => "gameCenterLeaderboardReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardRelationshipsReleasesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardReleases" => GameCenterLeaderboardRelationshipsReleasesDataItemType.GameCenterLeaderboardReleases,
                _ => null,
            };
        }
    }
}