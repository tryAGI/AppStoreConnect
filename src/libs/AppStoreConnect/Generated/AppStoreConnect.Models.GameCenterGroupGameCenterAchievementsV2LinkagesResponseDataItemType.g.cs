
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupGameCenterAchievementsV2LinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterGroupGameCenterAchievementsV2LinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupGameCenterAchievementsV2LinkagesResponseDataItemType value)
        {
            return value switch
            {
                GameCenterGroupGameCenterAchievementsV2LinkagesResponseDataItemType.GameCenterAchievements => "gameCenterAchievements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupGameCenterAchievementsV2LinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => GameCenterGroupGameCenterAchievementsV2LinkagesResponseDataItemType.GameCenterAchievements,
                _ => null,
            };
        }
    }
}