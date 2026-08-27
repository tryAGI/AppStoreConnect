
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterActivityAchievementsLinkagesRequestDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterAchievements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityAchievementsLinkagesRequestDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityAchievementsLinkagesRequestDataItemType value)
        {
            return value switch
            {
                GameCenterActivityAchievementsLinkagesRequestDataItemType.GameCenterAchievements => "gameCenterAchievements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityAchievementsLinkagesRequestDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => GameCenterActivityAchievementsLinkagesRequestDataItemType.GameCenterAchievements,
                _ => null,
            };
        }
    }
}