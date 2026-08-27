
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipDefaultExperience
    {
        /// <summary>
        /// 
        /// </summary>
        Action,
        /// <summary>
        /// 
        /// </summary>
        AppClip,
        /// <summary>
        /// 
        /// </summary>
        AppClipAppStoreReviewDetail,
        /// <summary>
        /// 
        /// </summary>
        AppClipDefaultExperienceLocalizations,
        /// <summary>
        /// 
        /// </summary>
        ReleaseWithAppStoreVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipDefaultExperienceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipDefaultExperience value)
        {
            return value switch
            {
                AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipDefaultExperience.Action => "action",
                AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipDefaultExperience.AppClip => "appClip",
                AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipDefaultExperience.AppClipAppStoreReviewDetail => "appClipAppStoreReviewDetail",
                AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipDefaultExperience.AppClipDefaultExperienceLocalizations => "appClipDefaultExperienceLocalizations",
                AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipDefaultExperience.ReleaseWithAppStoreVersion => "releaseWithAppStoreVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipDefaultExperience? ToEnum(string value)
        {
            return value switch
            {
                "action" => AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipDefaultExperience.Action,
                "appClip" => AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipDefaultExperience.AppClip,
                "appClipAppStoreReviewDetail" => AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipDefaultExperience.AppClipAppStoreReviewDetail,
                "appClipDefaultExperienceLocalizations" => AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipDefaultExperience.AppClipDefaultExperienceLocalizations,
                "releaseWithAppStoreVersion" => AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipDefaultExperience.ReleaseWithAppStoreVersion,
                _ => null,
            };
        }
    }
}