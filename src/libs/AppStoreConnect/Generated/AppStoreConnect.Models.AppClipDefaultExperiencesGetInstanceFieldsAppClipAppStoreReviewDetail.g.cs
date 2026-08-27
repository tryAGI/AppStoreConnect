
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipDefaultExperiencesGetInstanceFieldsAppClipAppStoreReviewDetail
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
    public static class AppClipDefaultExperiencesGetInstanceFieldsAppClipAppStoreReviewDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperiencesGetInstanceFieldsAppClipAppStoreReviewDetail value)
        {
            return value switch
            {
                AppClipDefaultExperiencesGetInstanceFieldsAppClipAppStoreReviewDetail.AppClipDefaultExperience => "appClipDefaultExperience",
                AppClipDefaultExperiencesGetInstanceFieldsAppClipAppStoreReviewDetail.InvocationUrls => "invocationUrls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperiencesGetInstanceFieldsAppClipAppStoreReviewDetail? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperience" => AppClipDefaultExperiencesGetInstanceFieldsAppClipAppStoreReviewDetail.AppClipDefaultExperience,
                "invocationUrls" => AppClipDefaultExperiencesGetInstanceFieldsAppClipAppStoreReviewDetail.InvocationUrls,
                _ => null,
            };
        }
    }
}