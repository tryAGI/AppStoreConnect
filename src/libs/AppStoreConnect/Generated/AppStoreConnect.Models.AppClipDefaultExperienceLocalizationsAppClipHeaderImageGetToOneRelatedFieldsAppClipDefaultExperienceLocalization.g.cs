
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipDefaultExperienceLocalization
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
    public static class AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipDefaultExperienceLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipDefaultExperienceLocalization value)
        {
            return value switch
            {
                AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipDefaultExperienceLocalization.AppClipDefaultExperience => "appClipDefaultExperience",
                AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipDefaultExperienceLocalization.AppClipHeaderImage => "appClipHeaderImage",
                AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipDefaultExperienceLocalization.Locale => "locale",
                AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipDefaultExperienceLocalization.Subtitle => "subtitle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipDefaultExperienceLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperience" => AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipDefaultExperienceLocalization.AppClipDefaultExperience,
                "appClipHeaderImage" => AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipDefaultExperienceLocalization.AppClipHeaderImage,
                "locale" => AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipDefaultExperienceLocalization.Locale,
                "subtitle" => AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipDefaultExperienceLocalization.Subtitle,
                _ => null,
            };
        }
    }
}