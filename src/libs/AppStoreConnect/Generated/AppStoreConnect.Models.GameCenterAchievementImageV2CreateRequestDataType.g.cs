
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementImageV2CreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievementImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementImageV2CreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementImageV2CreateRequestDataType value)
        {
            return value switch
            {
                GameCenterAchievementImageV2CreateRequestDataType.GameCenterAchievementImages => "gameCenterAchievementImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementImageV2CreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementImages" => GameCenterAchievementImageV2CreateRequestDataType.GameCenterAchievementImages,
                _ => null,
            };
        }
    }
}