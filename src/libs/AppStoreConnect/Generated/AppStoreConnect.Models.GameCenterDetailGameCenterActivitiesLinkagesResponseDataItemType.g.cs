
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailGameCenterActivitiesLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterActivities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailGameCenterActivitiesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailGameCenterActivitiesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                GameCenterDetailGameCenterActivitiesLinkagesResponseDataItemType.GameCenterActivities => "gameCenterActivities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailGameCenterActivitiesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivities" => GameCenterDetailGameCenterActivitiesLinkagesResponseDataItemType.GameCenterActivities,
                _ => null,
            };
        }
    }
}