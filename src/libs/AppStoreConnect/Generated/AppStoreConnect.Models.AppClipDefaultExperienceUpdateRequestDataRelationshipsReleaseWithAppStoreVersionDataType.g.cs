
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipDefaultExperienceUpdateRequestDataRelationshipsReleaseWithAppStoreVersionDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipDefaultExperienceUpdateRequestDataRelationshipsReleaseWithAppStoreVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperienceUpdateRequestDataRelationshipsReleaseWithAppStoreVersionDataType value)
        {
            return value switch
            {
                AppClipDefaultExperienceUpdateRequestDataRelationshipsReleaseWithAppStoreVersionDataType.AppStoreVersions => "appStoreVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperienceUpdateRequestDataRelationshipsReleaseWithAppStoreVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersions" => AppClipDefaultExperienceUpdateRequestDataRelationshipsReleaseWithAppStoreVersionDataType.AppStoreVersions,
                _ => null,
            };
        }
    }
}