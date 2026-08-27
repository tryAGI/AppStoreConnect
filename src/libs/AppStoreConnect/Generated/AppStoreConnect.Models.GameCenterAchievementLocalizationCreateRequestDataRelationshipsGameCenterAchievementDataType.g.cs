
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementLocalizationCreateRequestDataRelationshipsGameCenterAchievementDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementLocalizationCreateRequestDataRelationshipsGameCenterAchievementDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationCreateRequestDataRelationshipsGameCenterAchievementDataType value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationCreateRequestDataRelationshipsGameCenterAchievementDataType.GameCenterAchievements => "gameCenterAchievements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationCreateRequestDataRelationshipsGameCenterAchievementDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => GameCenterAchievementLocalizationCreateRequestDataRelationshipsGameCenterAchievementDataType.GameCenterAchievements,
                _ => null,
            };
        }
    }
}