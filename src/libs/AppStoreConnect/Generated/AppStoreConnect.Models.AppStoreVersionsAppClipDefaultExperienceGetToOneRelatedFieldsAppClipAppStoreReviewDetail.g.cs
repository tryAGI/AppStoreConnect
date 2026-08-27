
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipAppStoreReviewDetail
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
    public static class AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipAppStoreReviewDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipAppStoreReviewDetail value)
        {
            return value switch
            {
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipAppStoreReviewDetail.AppClipDefaultExperience => "appClipDefaultExperience",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipAppStoreReviewDetail.InvocationUrls => "invocationUrls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipAppStoreReviewDetail? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperience" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipAppStoreReviewDetail.AppClipDefaultExperience,
                "invocationUrls" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipAppStoreReviewDetail.InvocationUrls,
                _ => null,
            };
        }
    }
}