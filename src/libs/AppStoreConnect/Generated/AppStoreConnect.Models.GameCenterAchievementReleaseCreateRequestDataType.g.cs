
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementReleaseCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterAchievementReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementReleaseCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementReleaseCreateRequestDataType value)
        {
            return value switch
            {
                GameCenterAchievementReleaseCreateRequestDataType.GameCenterAchievementReleases => "gameCenterAchievementReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementReleaseCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementReleases" => GameCenterAchievementReleaseCreateRequestDataType.GameCenterAchievementReleases,
                _ => null,
            };
        }
    }
}