
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionRelationshipsGameCenterAppVersionDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterAppVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionRelationshipsGameCenterAppVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionRelationshipsGameCenterAppVersionDataType value)
        {
            return value switch
            {
                AppStoreVersionRelationshipsGameCenterAppVersionDataType.GameCenterAppVersions => "gameCenterAppVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionRelationshipsGameCenterAppVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAppVersions" => AppStoreVersionRelationshipsGameCenterAppVersionDataType.GameCenterAppVersions,
                _ => null,
            };
        }
    }
}