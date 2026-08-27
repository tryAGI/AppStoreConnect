
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAppVersionRelationshipsCompatibilityVersionsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAppVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAppVersionRelationshipsCompatibilityVersionsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAppVersionRelationshipsCompatibilityVersionsDataItemType value)
        {
            return value switch
            {
                GameCenterAppVersionRelationshipsCompatibilityVersionsDataItemType.GameCenterAppVersions => "gameCenterAppVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAppVersionRelationshipsCompatibilityVersionsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAppVersions" => GameCenterAppVersionRelationshipsCompatibilityVersionsDataItemType.GameCenterAppVersions,
                _ => null,
            };
        }
    }
}