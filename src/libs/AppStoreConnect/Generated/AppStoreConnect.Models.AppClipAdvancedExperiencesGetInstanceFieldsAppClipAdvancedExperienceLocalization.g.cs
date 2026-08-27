
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperienceLocalization
    {
        /// <summary>
        ///
        /// </summary>
        Language,
        /// <summary>
        ///
        /// </summary>
        Subtitle,
        /// <summary>
        ///
        /// </summary>
        Title,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperienceLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperienceLocalization value)
        {
            return value switch
            {
                AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperienceLocalization.Language => "language",
                AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperienceLocalization.Subtitle => "subtitle",
                AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperienceLocalization.Title => "title",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperienceLocalization? ToEnum(string value)
        {
            return value switch
            {
                "language" => AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperienceLocalization.Language,
                "subtitle" => AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperienceLocalization.Subtitle,
                "title" => AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperienceLocalization.Title,
                _ => null,
            };
        }
    }
}