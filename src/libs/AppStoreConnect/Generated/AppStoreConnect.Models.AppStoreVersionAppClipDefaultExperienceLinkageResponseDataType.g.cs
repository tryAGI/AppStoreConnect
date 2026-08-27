
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionAppClipDefaultExperienceLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppClipDefaultExperiences,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionAppClipDefaultExperienceLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionAppClipDefaultExperienceLinkageResponseDataType value)
        {
            return value switch
            {
                AppStoreVersionAppClipDefaultExperienceLinkageResponseDataType.AppClipDefaultExperiences => "appClipDefaultExperiences",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionAppClipDefaultExperienceLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperiences" => AppStoreVersionAppClipDefaultExperienceLinkageResponseDataType.AppClipDefaultExperiences,
                _ => null,
            };
        }
    }
}