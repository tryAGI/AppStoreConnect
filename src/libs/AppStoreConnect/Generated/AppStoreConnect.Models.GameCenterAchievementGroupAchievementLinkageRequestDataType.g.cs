
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementGroupAchievementLinkageRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementGroupAchievementLinkageRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementGroupAchievementLinkageRequestDataType value)
        {
            return value switch
            {
                GameCenterAchievementGroupAchievementLinkageRequestDataType.GameCenterAchievements => "gameCenterAchievements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementGroupAchievementLinkageRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => GameCenterAchievementGroupAchievementLinkageRequestDataType.GameCenterAchievements,
                _ => null,
            };
        }
    }
}