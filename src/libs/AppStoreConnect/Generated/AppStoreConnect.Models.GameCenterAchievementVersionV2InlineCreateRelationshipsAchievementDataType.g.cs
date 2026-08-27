
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementVersionV2InlineCreateRelationshipsAchievementDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterAchievements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementVersionV2InlineCreateRelationshipsAchievementDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementVersionV2InlineCreateRelationshipsAchievementDataType value)
        {
            return value switch
            {
                GameCenterAchievementVersionV2InlineCreateRelationshipsAchievementDataType.GameCenterAchievements => "gameCenterAchievements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementVersionV2InlineCreateRelationshipsAchievementDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => GameCenterAchievementVersionV2InlineCreateRelationshipsAchievementDataType.GameCenterAchievements,
                _ => null,
            };
        }
    }
}