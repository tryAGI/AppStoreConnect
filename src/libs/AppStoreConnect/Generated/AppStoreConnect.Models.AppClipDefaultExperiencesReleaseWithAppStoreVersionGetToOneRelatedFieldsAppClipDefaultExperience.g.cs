
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience
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
    public static class AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperienceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience value)
        {
            return value switch
            {
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience.Action => "action",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience.AppClip => "appClip",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience.AppClipAppStoreReviewDetail => "appClipAppStoreReviewDetail",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience.AppClipDefaultExperienceLocalizations => "appClipDefaultExperienceLocalizations",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience.ReleaseWithAppStoreVersion => "releaseWithAppStoreVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience? ToEnum(string value)
        {
            return value switch
            {
                "action" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience.Action,
                "appClip" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience.AppClip,
                "appClipAppStoreReviewDetail" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience.AppClipAppStoreReviewDetail,
                "appClipDefaultExperienceLocalizations" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience.AppClipDefaultExperienceLocalizations,
                "releaseWithAppStoreVersion" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience.ReleaseWithAppStoreVersion,
                _ => null,
            };
        }
    }
}