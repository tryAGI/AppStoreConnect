
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementsV2ResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievementVersions,
        /// <summary>
        ///
        /// </summary>
        GameCenterActivities,
        /// <summary>
        ///
        /// </summary>
        GameCenterDetails,
        /// <summary>
        ///
        /// </summary>
        GameCenterGroups,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementsV2ResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementsV2ResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterAchievementsV2ResponseIncludedItemDiscriminatorType.GameCenterAchievementVersions => "gameCenterAchievementVersions",
                GameCenterAchievementsV2ResponseIncludedItemDiscriminatorType.GameCenterActivities => "gameCenterActivities",
                GameCenterAchievementsV2ResponseIncludedItemDiscriminatorType.GameCenterDetails => "gameCenterDetails",
                GameCenterAchievementsV2ResponseIncludedItemDiscriminatorType.GameCenterGroups => "gameCenterGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementsV2ResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementVersions" => GameCenterAchievementsV2ResponseIncludedItemDiscriminatorType.GameCenterAchievementVersions,
                "gameCenterActivities" => GameCenterAchievementsV2ResponseIncludedItemDiscriminatorType.GameCenterActivities,
                "gameCenterDetails" => GameCenterAchievementsV2ResponseIncludedItemDiscriminatorType.GameCenterDetails,
                "gameCenterGroups" => GameCenterAchievementsV2ResponseIncludedItemDiscriminatorType.GameCenterGroups,
                _ => null,
            };
        }
    }
}