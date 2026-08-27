
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailAchievementReleasesLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievementReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailAchievementReleasesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailAchievementReleasesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                GameCenterDetailAchievementReleasesLinkagesResponseDataItemType.GameCenterAchievementReleases => "gameCenterAchievementReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailAchievementReleasesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementReleases" => GameCenterDetailAchievementReleasesLinkagesResponseDataItemType.GameCenterAchievementReleases,
                _ => null,
            };
        }
    }
}