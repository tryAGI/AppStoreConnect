
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementLocalizationCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievementLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementLocalizationCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationCreateRequestDataType value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationCreateRequestDataType.GameCenterAchievementLocalizations => "gameCenterAchievementLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementLocalizations" => GameCenterAchievementLocalizationCreateRequestDataType.GameCenterAchievementLocalizations,
                _ => null,
            };
        }
    }
}