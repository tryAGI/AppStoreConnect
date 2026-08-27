
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementLocalizationsV2ResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievementImages,
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievementVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementLocalizationsV2ResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationsV2ResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationsV2ResponseIncludedItemDiscriminatorType.GameCenterAchievementImages => "gameCenterAchievementImages",
                GameCenterAchievementLocalizationsV2ResponseIncludedItemDiscriminatorType.GameCenterAchievementVersions => "gameCenterAchievementVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationsV2ResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementImages" => GameCenterAchievementLocalizationsV2ResponseIncludedItemDiscriminatorType.GameCenterAchievementImages,
                "gameCenterAchievementVersions" => GameCenterAchievementLocalizationsV2ResponseIncludedItemDiscriminatorType.GameCenterAchievementVersions,
                _ => null,
            };
        }
    }
}