
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupRelationshipsGameCenterAchievementsV2DataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterGroupRelationshipsGameCenterAchievementsV2DataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupRelationshipsGameCenterAchievementsV2DataItemType value)
        {
            return value switch
            {
                GameCenterGroupRelationshipsGameCenterAchievementsV2DataItemType.GameCenterAchievements => "gameCenterAchievements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupRelationshipsGameCenterAchievementsV2DataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => GameCenterGroupRelationshipsGameCenterAchievementsV2DataItemType.GameCenterAchievements,
                _ => null,
            };
        }
    }
}