
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementRelationshipsReleasesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievementReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementRelationshipsReleasesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementRelationshipsReleasesDataItemType value)
        {
            return value switch
            {
                GameCenterAchievementRelationshipsReleasesDataItemType.GameCenterAchievementReleases => "gameCenterAchievementReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementRelationshipsReleasesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementReleases" => GameCenterAchievementRelationshipsReleasesDataItemType.GameCenterAchievementReleases,
                _ => null,
            };
        }
    }
}