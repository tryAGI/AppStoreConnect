
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionAppClipDefaultExperienceLinkageRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipDefaultExperiences,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionAppClipDefaultExperienceLinkageRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionAppClipDefaultExperienceLinkageRequestDataType value)
        {
            return value switch
            {
                AppStoreVersionAppClipDefaultExperienceLinkageRequestDataType.AppClipDefaultExperiences => "appClipDefaultExperiences",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionAppClipDefaultExperienceLinkageRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperiences" => AppStoreVersionAppClipDefaultExperienceLinkageRequestDataType.AppClipDefaultExperiences,
                _ => null,
            };
        }
    }
}