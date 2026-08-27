
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementImageV2UpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievementImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementImageV2UpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementImageV2UpdateRequestDataType value)
        {
            return value switch
            {
                GameCenterAchievementImageV2UpdateRequestDataType.GameCenterAchievementImages => "gameCenterAchievementImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementImageV2UpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementImages" => GameCenterAchievementImageV2UpdateRequestDataType.GameCenterAchievementImages,
                _ => null,
            };
        }
    }
}