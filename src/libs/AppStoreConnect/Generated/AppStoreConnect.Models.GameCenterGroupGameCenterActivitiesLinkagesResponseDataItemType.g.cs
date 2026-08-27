
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupGameCenterActivitiesLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterActivities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterGroupGameCenterActivitiesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupGameCenterActivitiesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                GameCenterGroupGameCenterActivitiesLinkagesResponseDataItemType.GameCenterActivities => "gameCenterActivities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupGameCenterActivitiesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivities" => GameCenterGroupGameCenterActivitiesLinkagesResponseDataItemType.GameCenterActivities,
                _ => null,
            };
        }
    }
}