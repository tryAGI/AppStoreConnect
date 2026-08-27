
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementRelationshipsGameCenterGroupDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterGroups,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementRelationshipsGameCenterGroupDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementRelationshipsGameCenterGroupDataType value)
        {
            return value switch
            {
                GameCenterAchievementRelationshipsGameCenterGroupDataType.GameCenterGroups => "gameCenterGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementRelationshipsGameCenterGroupDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterGroups" => GameCenterAchievementRelationshipsGameCenterGroupDataType.GameCenterGroups,
                _ => null,
            };
        }
    }
}