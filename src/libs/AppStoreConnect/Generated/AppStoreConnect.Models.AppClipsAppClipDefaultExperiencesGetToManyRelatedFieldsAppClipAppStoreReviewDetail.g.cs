
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipAppStoreReviewDetail
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipDefaultExperience,
        /// <summary>
        /// 
        /// </summary>
        InvocationUrls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipAppStoreReviewDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipAppStoreReviewDetail value)
        {
            return value switch
            {
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipAppStoreReviewDetail.AppClipDefaultExperience => "appClipDefaultExperience",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipAppStoreReviewDetail.InvocationUrls => "invocationUrls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipAppStoreReviewDetail? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperience" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipAppStoreReviewDetail.AppClipDefaultExperience,
                "invocationUrls" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipAppStoreReviewDetail.InvocationUrls,
                _ => null,
            };
        }
    }
}