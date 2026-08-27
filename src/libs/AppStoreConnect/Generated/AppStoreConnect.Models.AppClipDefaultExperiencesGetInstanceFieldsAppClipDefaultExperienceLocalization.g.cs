
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipDefaultExperiencesGetInstanceFieldsAppClipDefaultExperienceLocalization
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
    public static class AppClipDefaultExperiencesGetInstanceFieldsAppClipDefaultExperienceLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperiencesGetInstanceFieldsAppClipDefaultExperienceLocalization value)
        {
            return value switch
            {
                AppClipDefaultExperiencesGetInstanceFieldsAppClipDefaultExperienceLocalization.AppClipDefaultExperience => "appClipDefaultExperience",
                AppClipDefaultExperiencesGetInstanceFieldsAppClipDefaultExperienceLocalization.AppClipHeaderImage => "appClipHeaderImage",
                AppClipDefaultExperiencesGetInstanceFieldsAppClipDefaultExperienceLocalization.Locale => "locale",
                AppClipDefaultExperiencesGetInstanceFieldsAppClipDefaultExperienceLocalization.Subtitle => "subtitle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperiencesGetInstanceFieldsAppClipDefaultExperienceLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperience" => AppClipDefaultExperiencesGetInstanceFieldsAppClipDefaultExperienceLocalization.AppClipDefaultExperience,
                "appClipHeaderImage" => AppClipDefaultExperiencesGetInstanceFieldsAppClipDefaultExperienceLocalization.AppClipHeaderImage,
                "locale" => AppClipDefaultExperiencesGetInstanceFieldsAppClipDefaultExperienceLocalization.Locale,
                "subtitle" => AppClipDefaultExperiencesGetInstanceFieldsAppClipDefaultExperienceLocalization.Subtitle,
                _ => null,
            };
        }
    }
}