
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementImageRelationshipsGameCenterAchievementLocalizationDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievementLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementImageRelationshipsGameCenterAchievementLocalizationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementImageRelationshipsGameCenterAchievementLocalizationDataType value)
        {
            return value switch
            {
                GameCenterAchievementImageRelationshipsGameCenterAchievementLocalizationDataType.GameCenterAchievementLocalizations => "gameCenterAchievementLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementImageRelationshipsGameCenterAchievementLocalizationDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementLocalizations" => GameCenterAchievementImageRelationshipsGameCenterAchievementLocalizationDataType.GameCenterAchievementLocalizations,
                _ => null,
            };
        }
    }
}