
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementVersionV2LocalizationsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievementLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementVersionV2LocalizationsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementVersionV2LocalizationsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                GameCenterAchievementVersionV2LocalizationsLinkagesResponseDataItemType.GameCenterAchievementLocalizations => "gameCenterAchievementLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementVersionV2LocalizationsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementLocalizations" => GameCenterAchievementVersionV2LocalizationsLinkagesResponseDataItemType.GameCenterAchievementLocalizations,
                _ => null,
            };
        }
    }
}