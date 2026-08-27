
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGetInstanceFieldsAppClip
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
    public static class AppsGetInstanceFieldsAppClipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetInstanceFieldsAppClip value)
        {
            return value switch
            {
                AppsGetInstanceFieldsAppClip.App => "app",
                AppsGetInstanceFieldsAppClip.AppClipAdvancedExperiences => "appClipAdvancedExperiences",
                AppsGetInstanceFieldsAppClip.AppClipDefaultExperiences => "appClipDefaultExperiences",
                AppsGetInstanceFieldsAppClip.BundleId => "bundleId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetInstanceFieldsAppClip? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsGetInstanceFieldsAppClip.App,
                "appClipAdvancedExperiences" => AppsGetInstanceFieldsAppClip.AppClipAdvancedExperiences,
                "appClipDefaultExperiences" => AppsGetInstanceFieldsAppClip.AppClipDefaultExperiences,
                "bundleId" => AppsGetInstanceFieldsAppClip.BundleId,
                _ => null,
            };
        }
    }
}