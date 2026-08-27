
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailRelationshipsGameCenterAppVersionsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAppVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailRelationshipsGameCenterAppVersionsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailRelationshipsGameCenterAppVersionsDataItemType value)
        {
            return value switch
            {
                GameCenterDetailRelationshipsGameCenterAppVersionsDataItemType.GameCenterAppVersions => "gameCenterAppVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailRelationshipsGameCenterAppVersionsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAppVersions" => GameCenterDetailRelationshipsGameCenterAppVersionsDataItemType.GameCenterAppVersions,
                _ => null,
            };
        }
    }
}