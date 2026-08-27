
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementRelationshipsActivityDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterActivities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementRelationshipsActivityDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementRelationshipsActivityDataType value)
        {
            return value switch
            {
                GameCenterAchievementRelationshipsActivityDataType.GameCenterActivities => "gameCenterActivities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementRelationshipsActivityDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivities" => GameCenterAchievementRelationshipsActivityDataType.GameCenterActivities,
                _ => null,
            };
        }
    }
}