
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperience
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
    public static class AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperienceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperience value)
        {
            return value switch
            {
                AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperience.Action => "action",
                AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperience.AppClip => "appClip",
                AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperience.AppClipAppStoreReviewDetail => "appClipAppStoreReviewDetail",
                AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperience.AppClipDefaultExperienceLocalizations => "appClipDefaultExperienceLocalizations",
                AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperience.ReleaseWithAppStoreVersion => "releaseWithAppStoreVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperience? ToEnum(string value)
        {
            return value switch
            {
                "action" => AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperience.Action,
                "appClip" => AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperience.AppClip,
                "appClipAppStoreReviewDetail" => AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperience.AppClipAppStoreReviewDetail,
                "appClipDefaultExperienceLocalizations" => AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperience.AppClipDefaultExperienceLocalizations,
                "releaseWithAppStoreVersion" => AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperience.ReleaseWithAppStoreVersion,
                _ => null,
            };
        }
    }
}