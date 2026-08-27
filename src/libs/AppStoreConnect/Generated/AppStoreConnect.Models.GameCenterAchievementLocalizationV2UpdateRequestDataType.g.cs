
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementLocalizationV2UpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievementLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementLocalizationV2UpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationV2UpdateRequestDataType value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationV2UpdateRequestDataType.GameCenterAchievementLocalizations => "gameCenterAchievementLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationV2UpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementLocalizations" => GameCenterAchievementLocalizationV2UpdateRequestDataType.GameCenterAchievementLocalizations,
                _ => null,
            };
        }
    }
}