
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipDefaultExperiencesGetInstanceFieldsAppClipDefaultExperience
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
    public static class AppClipDefaultExperiencesGetInstanceFieldsAppClipDefaultExperienceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperiencesGetInstanceFieldsAppClipDefaultExperience value)
        {
            return value switch
            {
                AppClipDefaultExperiencesGetInstanceFieldsAppClipDefaultExperience.Action => "action",
                AppClipDefaultExperiencesGetInstanceFieldsAppClipDefaultExperience.AppClip => "appClip",
                AppClipDefaultExperiencesGetInstanceFieldsAppClipDefaultExperience.AppClipAppStoreReviewDetail => "appClipAppStoreReviewDetail",
                AppClipDefaultExperiencesGetInstanceFieldsAppClipDefaultExperience.AppClipDefaultExperienceLocalizations => "appClipDefaultExperienceLocalizations",
                AppClipDefaultExperiencesGetInstanceFieldsAppClipDefaultExperience.ReleaseWithAppStoreVersion => "releaseWithAppStoreVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperiencesGetInstanceFieldsAppClipDefaultExperience? ToEnum(string value)
        {
            return value switch
            {
                "action" => AppClipDefaultExperiencesGetInstanceFieldsAppClipDefaultExperience.Action,
                "appClip" => AppClipDefaultExperiencesGetInstanceFieldsAppClipDefaultExperience.AppClip,
                "appClipAppStoreReviewDetail" => AppClipDefaultExperiencesGetInstanceFieldsAppClipDefaultExperience.AppClipAppStoreReviewDetail,
                "appClipDefaultExperienceLocalizations" => AppClipDefaultExperiencesGetInstanceFieldsAppClipDefaultExperience.AppClipDefaultExperienceLocalizations,
                "releaseWithAppStoreVersion" => AppClipDefaultExperiencesGetInstanceFieldsAppClipDefaultExperience.ReleaseWithAppStoreVersion,
                _ => null,
            };
        }
    }
}