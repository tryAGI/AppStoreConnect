
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementImageCreateRequestDataRelationshipsGameCenterAchievementLocalizationDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievementLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementImageCreateRequestDataRelationshipsGameCenterAchievementLocalizationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementImageCreateRequestDataRelationshipsGameCenterAchievementLocalizationDataType value)
        {
            return value switch
            {
                GameCenterAchievementImageCreateRequestDataRelationshipsGameCenterAchievementLocalizationDataType.GameCenterAchievementLocalizations => "gameCenterAchievementLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementImageCreateRequestDataRelationshipsGameCenterAchievementLocalizationDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementLocalizations" => GameCenterAchievementImageCreateRequestDataRelationshipsGameCenterAchievementLocalizationDataType.GameCenterAchievementLocalizations,
                _ => null,
            };
        }
    }
}