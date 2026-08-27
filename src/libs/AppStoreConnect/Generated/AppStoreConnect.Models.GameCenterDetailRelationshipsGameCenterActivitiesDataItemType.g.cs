
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailRelationshipsGameCenterActivitiesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterActivities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailRelationshipsGameCenterActivitiesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailRelationshipsGameCenterActivitiesDataItemType value)
        {
            return value switch
            {
                GameCenterDetailRelationshipsGameCenterActivitiesDataItemType.GameCenterActivities => "gameCenterActivities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailRelationshipsGameCenterActivitiesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivities" => GameCenterDetailRelationshipsGameCenterActivitiesDataItemType.GameCenterActivities,
                _ => null,
            };
        }
    }
}