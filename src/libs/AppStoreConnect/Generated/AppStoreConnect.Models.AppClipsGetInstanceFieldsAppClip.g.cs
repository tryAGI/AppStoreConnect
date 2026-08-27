
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipsGetInstanceFieldsAppClip
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
    public static class AppClipsGetInstanceFieldsAppClipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipsGetInstanceFieldsAppClip value)
        {
            return value switch
            {
                AppClipsGetInstanceFieldsAppClip.App => "app",
                AppClipsGetInstanceFieldsAppClip.AppClipAdvancedExperiences => "appClipAdvancedExperiences",
                AppClipsGetInstanceFieldsAppClip.AppClipDefaultExperiences => "appClipDefaultExperiences",
                AppClipsGetInstanceFieldsAppClip.BundleId => "bundleId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipsGetInstanceFieldsAppClip? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppClipsGetInstanceFieldsAppClip.App,
                "appClipAdvancedExperiences" => AppClipsGetInstanceFieldsAppClip.AppClipAdvancedExperiences,
                "appClipDefaultExperiences" => AppClipsGetInstanceFieldsAppClip.AppClipDefaultExperiences,
                "bundleId" => AppClipsGetInstanceFieldsAppClip.BundleId,
                _ => null,
            };
        }
    }
}