
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementLocalizationRelationshipsGameCenterAchievementImageDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterAchievementImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementLocalizationRelationshipsGameCenterAchievementImageDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationRelationshipsGameCenterAchievementImageDataType value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationRelationshipsGameCenterAchievementImageDataType.GameCenterAchievementImages => "gameCenterAchievementImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationRelationshipsGameCenterAchievementImageDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementImages" => GameCenterAchievementLocalizationRelationshipsGameCenterAchievementImageDataType.GameCenterAchievementImages,
                _ => null,
            };
        }
    }
}