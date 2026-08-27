
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGetCollectionFieldsAppClip
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
    public static class AppsGetCollectionFieldsAppClipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionFieldsAppClip value)
        {
            return value switch
            {
                AppsGetCollectionFieldsAppClip.App => "app",
                AppsGetCollectionFieldsAppClip.AppClipAdvancedExperiences => "appClipAdvancedExperiences",
                AppsGetCollectionFieldsAppClip.AppClipDefaultExperiences => "appClipDefaultExperiences",
                AppsGetCollectionFieldsAppClip.BundleId => "bundleId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionFieldsAppClip? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsGetCollectionFieldsAppClip.App,
                "appClipAdvancedExperiences" => AppsGetCollectionFieldsAppClip.AppClipAdvancedExperiences,
                "appClipDefaultExperiences" => AppsGetCollectionFieldsAppClip.AppClipDefaultExperiences,
                "bundleId" => AppsGetCollectionFieldsAppClip.BundleId,
                _ => null,
            };
        }
    }
}