
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementLocalizationGameCenterAchievementImageLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievementImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementLocalizationGameCenterAchievementImageLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationGameCenterAchievementImageLinkageResponseDataType value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationGameCenterAchievementImageLinkageResponseDataType.GameCenterAchievementImages => "gameCenterAchievementImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationGameCenterAchievementImageLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementImages" => GameCenterAchievementLocalizationGameCenterAchievementImageLinkageResponseDataType.GameCenterAchievementImages,
                _ => null,
            };
        }
    }
}