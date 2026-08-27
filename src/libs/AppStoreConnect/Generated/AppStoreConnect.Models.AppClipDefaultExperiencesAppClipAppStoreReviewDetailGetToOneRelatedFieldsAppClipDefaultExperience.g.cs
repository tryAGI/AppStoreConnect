
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipDefaultExperience
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
    public static class AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipDefaultExperienceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipDefaultExperience value)
        {
            return value switch
            {
                AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipDefaultExperience.Action => "action",
                AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipDefaultExperience.AppClip => "appClip",
                AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipDefaultExperience.AppClipAppStoreReviewDetail => "appClipAppStoreReviewDetail",
                AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipDefaultExperience.AppClipDefaultExperienceLocalizations => "appClipDefaultExperienceLocalizations",
                AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipDefaultExperience.ReleaseWithAppStoreVersion => "releaseWithAppStoreVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipDefaultExperience? ToEnum(string value)
        {
            return value switch
            {
                "action" => AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipDefaultExperience.Action,
                "appClip" => AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipDefaultExperience.AppClip,
                "appClipAppStoreReviewDetail" => AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipDefaultExperience.AppClipAppStoreReviewDetail,
                "appClipDefaultExperienceLocalizations" => AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipDefaultExperience.AppClipDefaultExperienceLocalizations,
                "releaseWithAppStoreVersion" => AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedFieldsAppClipDefaultExperience.ReleaseWithAppStoreVersion,
                _ => null,
            };
        }
    }
}