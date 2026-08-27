
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementLocalizationsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievementLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementLocalizationsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationsLinkagesResponseDataItemType.GameCenterAchievementLocalizations => "gameCenterAchievementLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementLocalizations" => GameCenterAchievementLocalizationsLinkagesResponseDataItemType.GameCenterAchievementLocalizations,
                _ => null,
            };
        }
    }
}