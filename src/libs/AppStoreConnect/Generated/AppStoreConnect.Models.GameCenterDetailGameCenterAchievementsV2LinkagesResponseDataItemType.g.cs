
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailGameCenterAchievementsV2LinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterAchievements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailGameCenterAchievementsV2LinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailGameCenterAchievementsV2LinkagesResponseDataItemType value)
        {
            return value switch
            {
                GameCenterDetailGameCenterAchievementsV2LinkagesResponseDataItemType.GameCenterAchievements => "gameCenterAchievements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailGameCenterAchievementsV2LinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => GameCenterDetailGameCenterAchievementsV2LinkagesResponseDataItemType.GameCenterAchievements,
                _ => null,
            };
        }
    }
}