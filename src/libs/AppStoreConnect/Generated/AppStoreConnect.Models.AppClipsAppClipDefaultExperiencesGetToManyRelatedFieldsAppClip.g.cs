
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClip
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
    public static class AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClip value)
        {
            return value switch
            {
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClip.App => "app",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClip.AppClipAdvancedExperiences => "appClipAdvancedExperiences",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClip.AppClipDefaultExperiences => "appClipDefaultExperiences",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClip.BundleId => "bundleId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClip? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClip.App,
                "appClipAdvancedExperiences" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClip.AppClipAdvancedExperiences,
                "appClipDefaultExperiences" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClip.AppClipDefaultExperiences,
                "bundleId" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClip.BundleId,
                _ => null,
            };
        }
    }
}