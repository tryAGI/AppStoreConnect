
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipAppStoreReviewDetail
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
    public static class AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipAppStoreReviewDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipAppStoreReviewDetail value)
        {
            return value switch
            {
                AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipAppStoreReviewDetail.AppClipDefaultExperience => "appClipDefaultExperience",
                AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipAppStoreReviewDetail.InvocationUrls => "invocationUrls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipAppStoreReviewDetail? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperience" => AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipAppStoreReviewDetail.AppClipDefaultExperience,
                "invocationUrls" => AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipAppStoreReviewDetail.InvocationUrls,
                _ => null,
            };
        }
    }
}