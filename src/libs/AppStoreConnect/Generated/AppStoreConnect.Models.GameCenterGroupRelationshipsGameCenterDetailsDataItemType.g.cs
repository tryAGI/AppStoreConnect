
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupRelationshipsGameCenterDetailsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterGroupRelationshipsGameCenterDetailsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupRelationshipsGameCenterDetailsDataItemType value)
        {
            return value switch
            {
                GameCenterGroupRelationshipsGameCenterDetailsDataItemType.GameCenterDetails => "gameCenterDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupRelationshipsGameCenterDetailsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetails" => GameCenterGroupRelationshipsGameCenterDetailsDataItemType.GameCenterDetails,
                _ => null,
            };
        }
    }
}