
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementLocalizationGameCenterAchievementLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterAchievements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementLocalizationGameCenterAchievementLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationGameCenterAchievementLinkageResponseDataType value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationGameCenterAchievementLinkageResponseDataType.GameCenterAchievements => "gameCenterAchievements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationGameCenterAchievementLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => GameCenterAchievementLocalizationGameCenterAchievementLinkageResponseDataType.GameCenterAchievements,
                _ => null,
            };
        }
    }
}