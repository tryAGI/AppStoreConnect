
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipDefaultExperienceCreateRequestDataRelationshipsReleaseWithAppStoreVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipDefaultExperienceCreateRequestDataRelationshipsReleaseWithAppStoreVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperienceCreateRequestDataRelationshipsReleaseWithAppStoreVersionDataType value)
        {
            return value switch
            {
                AppClipDefaultExperienceCreateRequestDataRelationshipsReleaseWithAppStoreVersionDataType.AppStoreVersions => "appStoreVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperienceCreateRequestDataRelationshipsReleaseWithAppStoreVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersions" => AppClipDefaultExperienceCreateRequestDataRelationshipsReleaseWithAppStoreVersionDataType.AppStoreVersions,
                _ => null,
            };
        }
    }
}