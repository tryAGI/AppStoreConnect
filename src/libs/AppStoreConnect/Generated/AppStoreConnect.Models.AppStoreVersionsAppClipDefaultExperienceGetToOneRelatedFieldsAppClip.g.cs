
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClip
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
    public static class AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClip value)
        {
            return value switch
            {
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClip.App => "app",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClip.AppClipAdvancedExperiences => "appClipAdvancedExperiences",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClip.AppClipDefaultExperiences => "appClipDefaultExperiences",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClip.BundleId => "bundleId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClip? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClip.App,
                "appClipAdvancedExperiences" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClip.AppClipAdvancedExperiences,
                "appClipDefaultExperiences" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClip.AppClipDefaultExperiences,
                "bundleId" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClip.BundleId,
                _ => null,
            };
        }
    }
}