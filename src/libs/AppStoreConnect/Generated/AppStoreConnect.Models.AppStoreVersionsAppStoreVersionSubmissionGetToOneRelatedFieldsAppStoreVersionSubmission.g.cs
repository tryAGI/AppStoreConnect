
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersionSubmission
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersionSubmissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersionSubmission value)
        {
            return value switch
            {
                AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersionSubmission.AppStoreVersion => "appStoreVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersionSubmission? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersionSubmission.AppStoreVersion,
                _ => null,
            };
        }
    }
}