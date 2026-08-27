
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipAdvancedExperiencesGetInstanceFieldsAppClip
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
    public static class AppClipAdvancedExperiencesGetInstanceFieldsAppClipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperiencesGetInstanceFieldsAppClip value)
        {
            return value switch
            {
                AppClipAdvancedExperiencesGetInstanceFieldsAppClip.App => "app",
                AppClipAdvancedExperiencesGetInstanceFieldsAppClip.AppClipAdvancedExperiences => "appClipAdvancedExperiences",
                AppClipAdvancedExperiencesGetInstanceFieldsAppClip.AppClipDefaultExperiences => "appClipDefaultExperiences",
                AppClipAdvancedExperiencesGetInstanceFieldsAppClip.BundleId => "bundleId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperiencesGetInstanceFieldsAppClip? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppClipAdvancedExperiencesGetInstanceFieldsAppClip.App,
                "appClipAdvancedExperiences" => AppClipAdvancedExperiencesGetInstanceFieldsAppClip.AppClipAdvancedExperiences,
                "appClipDefaultExperiences" => AppClipAdvancedExperiencesGetInstanceFieldsAppClip.AppClipDefaultExperiences,
                "bundleId" => AppClipAdvancedExperiencesGetInstanceFieldsAppClip.BundleId,
                _ => null,
            };
        }
    }
}