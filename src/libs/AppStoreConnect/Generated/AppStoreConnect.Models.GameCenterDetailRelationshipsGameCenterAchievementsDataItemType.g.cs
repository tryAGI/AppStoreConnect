
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailRelationshipsGameCenterAchievementsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailRelationshipsGameCenterAchievementsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailRelationshipsGameCenterAchievementsDataItemType value)
        {
            return value switch
            {
                GameCenterDetailRelationshipsGameCenterAchievementsDataItemType.GameCenterAchievements => "gameCenterAchievements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailRelationshipsGameCenterAchievementsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => GameCenterDetailRelationshipsGameCenterAchievementsDataItemType.GameCenterAchievements,
                _ => null,
            };
        }
    }
}