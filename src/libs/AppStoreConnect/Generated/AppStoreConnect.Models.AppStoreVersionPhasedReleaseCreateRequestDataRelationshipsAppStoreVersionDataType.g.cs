
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionPhasedReleaseCreateRequestDataRelationshipsAppStoreVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionPhasedReleaseCreateRequestDataRelationshipsAppStoreVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionPhasedReleaseCreateRequestDataRelationshipsAppStoreVersionDataType value)
        {
            return value switch
            {
                AppStoreVersionPhasedReleaseCreateRequestDataRelationshipsAppStoreVersionDataType.AppStoreVersions => "appStoreVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionPhasedReleaseCreateRequestDataRelationshipsAppStoreVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersions" => AppStoreVersionPhasedReleaseCreateRequestDataRelationshipsAppStoreVersionDataType.AppStoreVersions,
                _ => null,
            };
        }
    }
}