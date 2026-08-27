
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterPlayerAchievementSubmissionType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterPlayerAchievementSubmissions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterPlayerAchievementSubmissionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterPlayerAchievementSubmissionType value)
        {
            return value switch
            {
                GameCenterPlayerAchievementSubmissionType.GameCenterPlayerAchievementSubmissions => "gameCenterPlayerAchievementSubmissions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterPlayerAchievementSubmissionType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterPlayerAchievementSubmissions" => GameCenterPlayerAchievementSubmissionType.GameCenterPlayerAchievementSubmissions,
                _ => null,
            };
        }
    }
}