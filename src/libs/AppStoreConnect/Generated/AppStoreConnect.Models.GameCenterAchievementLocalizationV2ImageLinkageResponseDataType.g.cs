
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementLocalizationV2ImageLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievementImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementLocalizationV2ImageLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationV2ImageLinkageResponseDataType value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationV2ImageLinkageResponseDataType.GameCenterAchievementImages => "gameCenterAchievementImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationV2ImageLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementImages" => GameCenterAchievementLocalizationV2ImageLinkageResponseDataType.GameCenterAchievementImages,
                _ => null,
            };
        }
    }
}