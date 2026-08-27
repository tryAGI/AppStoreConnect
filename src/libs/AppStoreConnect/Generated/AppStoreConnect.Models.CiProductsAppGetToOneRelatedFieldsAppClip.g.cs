
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsAppGetToOneRelatedFieldsAppClip
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
    public static class CiProductsAppGetToOneRelatedFieldsAppClipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsAppGetToOneRelatedFieldsAppClip value)
        {
            return value switch
            {
                CiProductsAppGetToOneRelatedFieldsAppClip.App => "app",
                CiProductsAppGetToOneRelatedFieldsAppClip.AppClipAdvancedExperiences => "appClipAdvancedExperiences",
                CiProductsAppGetToOneRelatedFieldsAppClip.AppClipDefaultExperiences => "appClipDefaultExperiences",
                CiProductsAppGetToOneRelatedFieldsAppClip.BundleId => "bundleId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsAppGetToOneRelatedFieldsAppClip? ToEnum(string value)
        {
            return value switch
            {
                "app" => CiProductsAppGetToOneRelatedFieldsAppClip.App,
                "appClipAdvancedExperiences" => CiProductsAppGetToOneRelatedFieldsAppClip.AppClipAdvancedExperiences,
                "appClipDefaultExperiences" => CiProductsAppGetToOneRelatedFieldsAppClip.AppClipDefaultExperiences,
                "bundleId" => CiProductsAppGetToOneRelatedFieldsAppClip.BundleId,
                _ => null,
            };
        }
    }
}