
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppRelationshipsGameCenterEnabledVersionsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterEnabledVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppRelationshipsGameCenterEnabledVersionsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppRelationshipsGameCenterEnabledVersionsDataItemType value)
        {
            return value switch
            {
                AppRelationshipsGameCenterEnabledVersionsDataItemType.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppRelationshipsGameCenterEnabledVersionsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterEnabledVersions" => AppRelationshipsGameCenterEnabledVersionsDataItemType.GameCenterEnabledVersions,
                _ => null,
            };
        }
    }
}