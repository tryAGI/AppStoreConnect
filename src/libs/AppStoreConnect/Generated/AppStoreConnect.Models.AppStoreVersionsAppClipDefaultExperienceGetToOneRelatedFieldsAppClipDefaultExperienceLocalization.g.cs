
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperienceLocalization
    {
        /// <summary>
        ///
        /// </summary>
        AppClipDefaultExperience,
        /// <summary>
        ///
        /// </summary>
        AppClipHeaderImage,
        /// <summary>
        ///
        /// </summary>
        Locale,
        /// <summary>
        ///
        /// </summary>
        Subtitle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperienceLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperienceLocalization value)
        {
            return value switch
            {
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperienceLocalization.AppClipDefaultExperience => "appClipDefaultExperience",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperienceLocalization.AppClipHeaderImage => "appClipHeaderImage",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperienceLocalization.Locale => "locale",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperienceLocalization.Subtitle => "subtitle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperienceLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperience" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperienceLocalization.AppClipDefaultExperience,
                "appClipHeaderImage" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperienceLocalization.AppClipHeaderImage,
                "locale" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperienceLocalization.Locale,
                "subtitle" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperienceLocalization.Subtitle,
                _ => null,
            };
        }
    }
}