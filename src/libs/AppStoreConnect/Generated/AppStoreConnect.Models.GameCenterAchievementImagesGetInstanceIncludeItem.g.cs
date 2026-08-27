
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementImagesGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterAchievementLocalization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementImagesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementImagesGetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterAchievementImagesGetInstanceIncludeItem.GameCenterAchievementLocalization => "gameCenterAchievementLocalization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementImagesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementLocalization" => GameCenterAchievementImagesGetInstanceIncludeItem.GameCenterAchievementLocalization,
                _ => null,
            };
        }
    }
}