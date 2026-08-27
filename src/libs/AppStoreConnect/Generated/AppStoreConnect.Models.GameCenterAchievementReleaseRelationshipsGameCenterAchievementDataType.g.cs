
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementReleaseRelationshipsGameCenterAchievementDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementReleaseRelationshipsGameCenterAchievementDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementReleaseRelationshipsGameCenterAchievementDataType value)
        {
            return value switch
            {
                GameCenterAchievementReleaseRelationshipsGameCenterAchievementDataType.GameCenterAchievements => "gameCenterAchievements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementReleaseRelationshipsGameCenterAchievementDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => GameCenterAchievementReleaseRelationshipsGameCenterAchievementDataType.GameCenterAchievements,
                _ => null,
            };
        }
    }
}