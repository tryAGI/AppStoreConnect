
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipDefaultExperienceReleaseWithAppStoreVersionLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipDefaultExperienceReleaseWithAppStoreVersionLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperienceReleaseWithAppStoreVersionLinkageResponseDataType value)
        {
            return value switch
            {
                AppClipDefaultExperienceReleaseWithAppStoreVersionLinkageResponseDataType.AppStoreVersions => "appStoreVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperienceReleaseWithAppStoreVersionLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersions" => AppClipDefaultExperienceReleaseWithAppStoreVersionLinkageResponseDataType.AppStoreVersions,
                _ => null,
            };
        }
    }
}