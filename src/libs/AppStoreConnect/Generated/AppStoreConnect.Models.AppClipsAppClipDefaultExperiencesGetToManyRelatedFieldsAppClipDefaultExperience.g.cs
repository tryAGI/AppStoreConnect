
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipDefaultExperience
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
    public static class AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipDefaultExperienceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipDefaultExperience value)
        {
            return value switch
            {
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipDefaultExperience.Action => "action",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipDefaultExperience.AppClip => "appClip",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipDefaultExperience.AppClipAppStoreReviewDetail => "appClipAppStoreReviewDetail",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipDefaultExperience.AppClipDefaultExperienceLocalizations => "appClipDefaultExperienceLocalizations",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipDefaultExperience.ReleaseWithAppStoreVersion => "releaseWithAppStoreVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipDefaultExperience? ToEnum(string value)
        {
            return value switch
            {
                "action" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipDefaultExperience.Action,
                "appClip" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipDefaultExperience.AppClip,
                "appClipAppStoreReviewDetail" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipDefaultExperience.AppClipAppStoreReviewDetail,
                "appClipDefaultExperienceLocalizations" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipDefaultExperience.AppClipDefaultExperienceLocalizations,
                "releaseWithAppStoreVersion" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipDefaultExperience.ReleaseWithAppStoreVersion,
                _ => null,
            };
        }
    }
}