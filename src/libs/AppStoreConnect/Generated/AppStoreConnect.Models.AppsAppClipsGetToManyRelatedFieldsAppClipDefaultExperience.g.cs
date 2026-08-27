
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppClipsGetToManyRelatedFieldsAppClipDefaultExperience
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
    public static class AppsAppClipsGetToManyRelatedFieldsAppClipDefaultExperienceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppClipsGetToManyRelatedFieldsAppClipDefaultExperience value)
        {
            return value switch
            {
                AppsAppClipsGetToManyRelatedFieldsAppClipDefaultExperience.Action => "action",
                AppsAppClipsGetToManyRelatedFieldsAppClipDefaultExperience.AppClip => "appClip",
                AppsAppClipsGetToManyRelatedFieldsAppClipDefaultExperience.AppClipAppStoreReviewDetail => "appClipAppStoreReviewDetail",
                AppsAppClipsGetToManyRelatedFieldsAppClipDefaultExperience.AppClipDefaultExperienceLocalizations => "appClipDefaultExperienceLocalizations",
                AppsAppClipsGetToManyRelatedFieldsAppClipDefaultExperience.ReleaseWithAppStoreVersion => "releaseWithAppStoreVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppClipsGetToManyRelatedFieldsAppClipDefaultExperience? ToEnum(string value)
        {
            return value switch
            {
                "action" => AppsAppClipsGetToManyRelatedFieldsAppClipDefaultExperience.Action,
                "appClip" => AppsAppClipsGetToManyRelatedFieldsAppClipDefaultExperience.AppClip,
                "appClipAppStoreReviewDetail" => AppsAppClipsGetToManyRelatedFieldsAppClipDefaultExperience.AppClipAppStoreReviewDetail,
                "appClipDefaultExperienceLocalizations" => AppsAppClipsGetToManyRelatedFieldsAppClipDefaultExperience.AppClipDefaultExperienceLocalizations,
                "releaseWithAppStoreVersion" => AppsAppClipsGetToManyRelatedFieldsAppClipDefaultExperience.ReleaseWithAppStoreVersion,
                _ => null,
            };
        }
    }
}