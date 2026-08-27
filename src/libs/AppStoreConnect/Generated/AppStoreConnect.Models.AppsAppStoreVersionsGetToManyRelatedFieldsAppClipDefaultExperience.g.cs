
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsAppStoreVersionsGetToManyRelatedFieldsAppClipDefaultExperience
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
    public static class AppsAppStoreVersionsGetToManyRelatedFieldsAppClipDefaultExperienceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppStoreVersionsGetToManyRelatedFieldsAppClipDefaultExperience value)
        {
            return value switch
            {
                AppsAppStoreVersionsGetToManyRelatedFieldsAppClipDefaultExperience.Action => "action",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppClipDefaultExperience.AppClip => "appClip",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppClipDefaultExperience.AppClipAppStoreReviewDetail => "appClipAppStoreReviewDetail",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppClipDefaultExperience.AppClipDefaultExperienceLocalizations => "appClipDefaultExperienceLocalizations",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppClipDefaultExperience.ReleaseWithAppStoreVersion => "releaseWithAppStoreVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppStoreVersionsGetToManyRelatedFieldsAppClipDefaultExperience? ToEnum(string value)
        {
            return value switch
            {
                "action" => AppsAppStoreVersionsGetToManyRelatedFieldsAppClipDefaultExperience.Action,
                "appClip" => AppsAppStoreVersionsGetToManyRelatedFieldsAppClipDefaultExperience.AppClip,
                "appClipAppStoreReviewDetail" => AppsAppStoreVersionsGetToManyRelatedFieldsAppClipDefaultExperience.AppClipAppStoreReviewDetail,
                "appClipDefaultExperienceLocalizations" => AppsAppStoreVersionsGetToManyRelatedFieldsAppClipDefaultExperience.AppClipDefaultExperienceLocalizations,
                "releaseWithAppStoreVersion" => AppsAppStoreVersionsGetToManyRelatedFieldsAppClipDefaultExperience.ReleaseWithAppStoreVersion,
                _ => null,
            };
        }
    }
}