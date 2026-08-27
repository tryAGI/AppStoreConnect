
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterGroupRelationshipsGameCenterActivitiesDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterActivities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterGroupRelationshipsGameCenterActivitiesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupRelationshipsGameCenterActivitiesDataItemType value)
        {
            return value switch
            {
                GameCenterGroupRelationshipsGameCenterActivitiesDataItemType.GameCenterActivities => "gameCenterActivities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupRelationshipsGameCenterActivitiesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivities" => GameCenterGroupRelationshipsGameCenterActivitiesDataItemType.GameCenterActivities,
                _ => null,
            };
        }
    }
}