
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionReleaseRequestCreateRequestDataRelationshipsAppStoreVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionReleaseRequestCreateRequestDataRelationshipsAppStoreVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionReleaseRequestCreateRequestDataRelationshipsAppStoreVersionDataType value)
        {
            return value switch
            {
                AppStoreVersionReleaseRequestCreateRequestDataRelationshipsAppStoreVersionDataType.AppStoreVersions => "appStoreVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionReleaseRequestCreateRequestDataRelationshipsAppStoreVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersions" => AppStoreVersionReleaseRequestCreateRequestDataRelationshipsAppStoreVersionDataType.AppStoreVersions,
                _ => null,
            };
        }
    }
}