
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppRelationshipsAppStoreVersionsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppRelationshipsAppStoreVersionsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppRelationshipsAppStoreVersionsDataItemType value)
        {
            return value switch
            {
                AppRelationshipsAppStoreVersionsDataItemType.AppStoreVersions => "appStoreVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppRelationshipsAppStoreVersionsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersions" => AppRelationshipsAppStoreVersionsDataItemType.AppStoreVersions,
                _ => null,
            };
        }
    }
}