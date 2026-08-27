
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsAppClipsGetToManyRelatedFieldsAppClip
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
    public static class AppsAppClipsGetToManyRelatedFieldsAppClipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppClipsGetToManyRelatedFieldsAppClip value)
        {
            return value switch
            {
                AppsAppClipsGetToManyRelatedFieldsAppClip.App => "app",
                AppsAppClipsGetToManyRelatedFieldsAppClip.AppClipAdvancedExperiences => "appClipAdvancedExperiences",
                AppsAppClipsGetToManyRelatedFieldsAppClip.AppClipDefaultExperiences => "appClipDefaultExperiences",
                AppsAppClipsGetToManyRelatedFieldsAppClip.BundleId => "bundleId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppClipsGetToManyRelatedFieldsAppClip? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsAppClipsGetToManyRelatedFieldsAppClip.App,
                "appClipAdvancedExperiences" => AppsAppClipsGetToManyRelatedFieldsAppClip.AppClipAdvancedExperiences,
                "appClipDefaultExperiences" => AppsAppClipsGetToManyRelatedFieldsAppClip.AppClipDefaultExperiences,
                "bundleId" => AppsAppClipsGetToManyRelatedFieldsAppClip.BundleId,
                _ => null,
            };
        }
    }
}