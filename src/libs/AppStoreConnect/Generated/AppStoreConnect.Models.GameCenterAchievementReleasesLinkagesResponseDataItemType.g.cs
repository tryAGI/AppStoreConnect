
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementReleasesLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievementReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementReleasesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementReleasesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                GameCenterAchievementReleasesLinkagesResponseDataItemType.GameCenterAchievementReleases => "gameCenterAchievementReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementReleasesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementReleases" => GameCenterAchievementReleasesLinkagesResponseDataItemType.GameCenterAchievementReleases,
                _ => null,
            };
        }
    }
}