
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperienceLocalization
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
    public static class AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperienceLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperienceLocalization value)
        {
            return value switch
            {
                AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperienceLocalization.AppClipDefaultExperience => "appClipDefaultExperience",
                AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperienceLocalization.AppClipHeaderImage => "appClipHeaderImage",
                AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperienceLocalization.Locale => "locale",
                AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperienceLocalization.Subtitle => "subtitle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperienceLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperience" => AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperienceLocalization.AppClipDefaultExperience,
                "appClipHeaderImage" => AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperienceLocalization.AppClipHeaderImage,
                "locale" => AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperienceLocalization.Locale,
                "subtitle" => AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperienceLocalization.Subtitle,
                _ => null,
            };
        }
    }
}