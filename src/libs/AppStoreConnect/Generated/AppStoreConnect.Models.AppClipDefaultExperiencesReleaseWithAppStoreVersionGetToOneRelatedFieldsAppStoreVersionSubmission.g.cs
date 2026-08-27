
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission value)
        {
            return value switch
            {
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission.AppStoreVersion => "appStoreVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission.AppStoreVersion,
                _ => null,
            };
        }
    }
}