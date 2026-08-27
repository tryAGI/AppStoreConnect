
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipDefaultExperiencesGetInstanceFieldsAppClip
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
    public static class AppClipDefaultExperiencesGetInstanceFieldsAppClipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperiencesGetInstanceFieldsAppClip value)
        {
            return value switch
            {
                AppClipDefaultExperiencesGetInstanceFieldsAppClip.App => "app",
                AppClipDefaultExperiencesGetInstanceFieldsAppClip.AppClipAdvancedExperiences => "appClipAdvancedExperiences",
                AppClipDefaultExperiencesGetInstanceFieldsAppClip.AppClipDefaultExperiences => "appClipDefaultExperiences",
                AppClipDefaultExperiencesGetInstanceFieldsAppClip.BundleId => "bundleId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperiencesGetInstanceFieldsAppClip? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppClipDefaultExperiencesGetInstanceFieldsAppClip.App,
                "appClipAdvancedExperiences" => AppClipDefaultExperiencesGetInstanceFieldsAppClip.AppClipAdvancedExperiences,
                "appClipDefaultExperiences" => AppClipDefaultExperiencesGetInstanceFieldsAppClip.AppClipDefaultExperiences,
                "bundleId" => AppClipDefaultExperiencesGetInstanceFieldsAppClip.BundleId,
                _ => null,
            };
        }
    }
}