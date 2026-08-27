
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipDefaultExperienceReleaseWithAppStoreVersionLinkageRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipDefaultExperienceReleaseWithAppStoreVersionLinkageRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperienceReleaseWithAppStoreVersionLinkageRequestDataType value)
        {
            return value switch
            {
                AppClipDefaultExperienceReleaseWithAppStoreVersionLinkageRequestDataType.AppStoreVersions => "appStoreVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperienceReleaseWithAppStoreVersionLinkageRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersions" => AppClipDefaultExperienceReleaseWithAppStoreVersionLinkageRequestDataType.AppStoreVersions,
                _ => null,
            };
        }
    }
}