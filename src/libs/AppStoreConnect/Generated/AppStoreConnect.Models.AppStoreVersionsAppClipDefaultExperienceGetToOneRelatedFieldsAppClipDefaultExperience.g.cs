
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperience
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
    public static class AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperienceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperience value)
        {
            return value switch
            {
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperience.Action => "action",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperience.AppClip => "appClip",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperience.AppClipAppStoreReviewDetail => "appClipAppStoreReviewDetail",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperience.AppClipDefaultExperienceLocalizations => "appClipDefaultExperienceLocalizations",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperience.ReleaseWithAppStoreVersion => "releaseWithAppStoreVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperience? ToEnum(string value)
        {
            return value switch
            {
                "action" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperience.Action,
                "appClip" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperience.AppClip,
                "appClipAppStoreReviewDetail" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperience.AppClipAppStoreReviewDetail,
                "appClipDefaultExperienceLocalizations" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperience.AppClipDefaultExperienceLocalizations,
                "releaseWithAppStoreVersion" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperience.ReleaseWithAppStoreVersion,
                _ => null,
            };
        }
    }
}