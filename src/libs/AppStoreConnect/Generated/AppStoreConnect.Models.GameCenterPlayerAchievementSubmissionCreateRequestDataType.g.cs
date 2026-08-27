
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterPlayerAchievementSubmissionCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterPlayerAchievementSubmissions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterPlayerAchievementSubmissionCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterPlayerAchievementSubmissionCreateRequestDataType value)
        {
            return value switch
            {
                GameCenterPlayerAchievementSubmissionCreateRequestDataType.GameCenterPlayerAchievementSubmissions => "gameCenterPlayerAchievementSubmissions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterPlayerAchievementSubmissionCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterPlayerAchievementSubmissions" => GameCenterPlayerAchievementSubmissionCreateRequestDataType.GameCenterPlayerAchievementSubmissions,
                _ => null,
            };
        }
    }
}