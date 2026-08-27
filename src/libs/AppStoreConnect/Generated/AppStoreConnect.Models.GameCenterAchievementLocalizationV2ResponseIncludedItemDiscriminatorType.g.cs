
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementLocalizationV2ResponseIncludedItemDiscriminatorType
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
    public static class GameCenterAchievementLocalizationV2ResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationV2ResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationV2ResponseIncludedItemDiscriminatorType.GameCenterAchievementImages => "gameCenterAchievementImages",
                GameCenterAchievementLocalizationV2ResponseIncludedItemDiscriminatorType.GameCenterAchievementVersions => "gameCenterAchievementVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationV2ResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementImages" => GameCenterAchievementLocalizationV2ResponseIncludedItemDiscriminatorType.GameCenterAchievementImages,
                "gameCenterAchievementVersions" => GameCenterAchievementLocalizationV2ResponseIncludedItemDiscriminatorType.GameCenterAchievementVersions,
                _ => null,
            };
        }
    }
}