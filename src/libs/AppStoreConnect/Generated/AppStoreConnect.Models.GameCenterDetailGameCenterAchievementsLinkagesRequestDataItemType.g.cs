
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailGameCenterAchievementsLinkagesRequestDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterAchievements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailGameCenterAchievementsLinkagesRequestDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailGameCenterAchievementsLinkagesRequestDataItemType value)
        {
            return value switch
            {
                GameCenterDetailGameCenterAchievementsLinkagesRequestDataItemType.GameCenterAchievements => "gameCenterAchievements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailGameCenterAchievementsLinkagesRequestDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => GameCenterDetailGameCenterAchievementsLinkagesRequestDataItemType.GameCenterAchievements,
                _ => null,
            };
        }
    }
}