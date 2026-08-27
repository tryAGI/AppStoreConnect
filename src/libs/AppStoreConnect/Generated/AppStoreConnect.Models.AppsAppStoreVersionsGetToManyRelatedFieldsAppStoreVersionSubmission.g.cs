
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionSubmission
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionSubmissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionSubmission value)
        {
            return value switch
            {
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionSubmission.AppStoreVersion => "appStoreVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionSubmission? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionSubmission.AppStoreVersion,
                _ => null,
            };
        }
    }
}