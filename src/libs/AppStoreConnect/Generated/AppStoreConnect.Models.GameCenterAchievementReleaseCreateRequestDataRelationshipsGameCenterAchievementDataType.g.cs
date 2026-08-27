
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementReleaseCreateRequestDataRelationshipsGameCenterAchievementDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementReleaseCreateRequestDataRelationshipsGameCenterAchievementDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementReleaseCreateRequestDataRelationshipsGameCenterAchievementDataType value)
        {
            return value switch
            {
                GameCenterAchievementReleaseCreateRequestDataRelationshipsGameCenterAchievementDataType.GameCenterAchievements => "gameCenterAchievements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementReleaseCreateRequestDataRelationshipsGameCenterAchievementDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => GameCenterAchievementReleaseCreateRequestDataRelationshipsGameCenterAchievementDataType.GameCenterAchievements,
                _ => null,
            };
        }
    }
}