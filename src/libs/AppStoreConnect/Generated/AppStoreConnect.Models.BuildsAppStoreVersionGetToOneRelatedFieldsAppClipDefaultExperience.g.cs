
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience
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
    public static class BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperienceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience value)
        {
            return value switch
            {
                BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience.Action => "action",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience.AppClip => "appClip",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience.AppClipAppStoreReviewDetail => "appClipAppStoreReviewDetail",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience.AppClipDefaultExperienceLocalizations => "appClipDefaultExperienceLocalizations",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience.ReleaseWithAppStoreVersion => "releaseWithAppStoreVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience? ToEnum(string value)
        {
            return value switch
            {
                "action" => BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience.Action,
                "appClip" => BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience.AppClip,
                "appClipAppStoreReviewDetail" => BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience.AppClipAppStoreReviewDetail,
                "appClipDefaultExperienceLocalizations" => BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience.AppClipDefaultExperienceLocalizations,
                "releaseWithAppStoreVersion" => BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience.ReleaseWithAppStoreVersion,
                _ => null,
            };
        }
    }
}