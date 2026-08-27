
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionsGetInstanceFieldsAppStoreVersionSubmission
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionsGetInstanceFieldsAppStoreVersionSubmissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsGetInstanceFieldsAppStoreVersionSubmission value)
        {
            return value switch
            {
                AppStoreVersionsGetInstanceFieldsAppStoreVersionSubmission.AppStoreVersion => "appStoreVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsGetInstanceFieldsAppStoreVersionSubmission? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => AppStoreVersionsGetInstanceFieldsAppStoreVersionSubmission.AppStoreVersion,
                _ => null,
            };
        }
    }
}