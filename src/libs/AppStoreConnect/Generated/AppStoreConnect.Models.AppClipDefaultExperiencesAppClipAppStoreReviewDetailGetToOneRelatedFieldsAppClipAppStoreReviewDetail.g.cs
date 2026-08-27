
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipAppStoreReviewDetail
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
    public static class AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipAppStoreReviewDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipAppStoreReviewDetail value)
        {
            return value switch
            {
                AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipAppStoreReviewDetail.AppClipDefaultExperience => "appClipDefaultExperience",
                AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipAppStoreReviewDetail.InvocationUrls => "invocationUrls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipAppStoreReviewDetail? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperience" => AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipAppStoreReviewDetail.AppClipDefaultExperience,
                "invocationUrls" => AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipAppStoreReviewDetail.InvocationUrls,
                _ => null,
            };
        }
    }
}