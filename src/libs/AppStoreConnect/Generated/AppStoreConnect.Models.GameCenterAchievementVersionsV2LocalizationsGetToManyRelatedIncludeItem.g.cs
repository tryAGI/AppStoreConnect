
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedIncludeItem.Image => "image",
                GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedIncludeItem.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "image" => GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedIncludeItem.Image,
                "version" => GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedIncludeItem.Version,
                _ => null,
            };
        }
    }
}