
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipHeaderImagesGetInstanceFieldsAppClipDefaultExperienceLocalization
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
    public static class AppClipHeaderImagesGetInstanceFieldsAppClipDefaultExperienceLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipHeaderImagesGetInstanceFieldsAppClipDefaultExperienceLocalization value)
        {
            return value switch
            {
                AppClipHeaderImagesGetInstanceFieldsAppClipDefaultExperienceLocalization.AppClipDefaultExperience => "appClipDefaultExperience",
                AppClipHeaderImagesGetInstanceFieldsAppClipDefaultExperienceLocalization.AppClipHeaderImage => "appClipHeaderImage",
                AppClipHeaderImagesGetInstanceFieldsAppClipDefaultExperienceLocalization.Locale => "locale",
                AppClipHeaderImagesGetInstanceFieldsAppClipDefaultExperienceLocalization.Subtitle => "subtitle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipHeaderImagesGetInstanceFieldsAppClipDefaultExperienceLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperience" => AppClipHeaderImagesGetInstanceFieldsAppClipDefaultExperienceLocalization.AppClipDefaultExperience,
                "appClipHeaderImage" => AppClipHeaderImagesGetInstanceFieldsAppClipDefaultExperienceLocalization.AppClipHeaderImage,
                "locale" => AppClipHeaderImagesGetInstanceFieldsAppClipDefaultExperienceLocalization.Locale,
                "subtitle" => AppClipHeaderImagesGetInstanceFieldsAppClipDefaultExperienceLocalization.Subtitle,
                _ => null,
            };
        }
    }
}