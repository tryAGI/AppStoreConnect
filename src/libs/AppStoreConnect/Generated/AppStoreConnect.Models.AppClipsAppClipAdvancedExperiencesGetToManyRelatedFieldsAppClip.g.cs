
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClip
    {
        /// <summary>
        /// 
        /// </summary>
        App,
        /// <summary>
        /// 
        /// </summary>
        AppClipAdvancedExperiences,
        /// <summary>
        /// 
        /// </summary>
        AppClipDefaultExperiences,
        /// <summary>
        /// 
        /// </summary>
        BundleId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClip value)
        {
            return value switch
            {
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClip.App => "app",
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClip.AppClipAdvancedExperiences => "appClipAdvancedExperiences",
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClip.AppClipDefaultExperiences => "appClipDefaultExperiences",
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClip.BundleId => "bundleId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClip? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClip.App,
                "appClipAdvancedExperiences" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClip.AppClipAdvancedExperiences,
                "appClipDefaultExperiences" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClip.AppClipDefaultExperiences,
                "bundleId" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClip.BundleId,
                _ => null,
            };
        }
    }
}