
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementCreateRequestDataType value)
        {
            return value switch
            {
                GameCenterAchievementCreateRequestDataType.GameCenterAchievements => "gameCenterAchievements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => GameCenterAchievementCreateRequestDataType.GameCenterAchievements,
                _ => null,
            };
        }
    }
}