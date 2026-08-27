
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementV2ResponseIncludedItemDiscriminatorType
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
    public static class GameCenterAchievementV2ResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementV2ResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterAchievementV2ResponseIncludedItemDiscriminatorType.GameCenterAchievementVersions => "gameCenterAchievementVersions",
                GameCenterAchievementV2ResponseIncludedItemDiscriminatorType.GameCenterActivities => "gameCenterActivities",
                GameCenterAchievementV2ResponseIncludedItemDiscriminatorType.GameCenterDetails => "gameCenterDetails",
                GameCenterAchievementV2ResponseIncludedItemDiscriminatorType.GameCenterGroups => "gameCenterGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementV2ResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementVersions" => GameCenterAchievementV2ResponseIncludedItemDiscriminatorType.GameCenterAchievementVersions,
                "gameCenterActivities" => GameCenterAchievementV2ResponseIncludedItemDiscriminatorType.GameCenterActivities,
                "gameCenterDetails" => GameCenterAchievementV2ResponseIncludedItemDiscriminatorType.GameCenterDetails,
                "gameCenterGroups" => GameCenterAchievementV2ResponseIncludedItemDiscriminatorType.GameCenterGroups,
                _ => null,
            };
        }
    }
}