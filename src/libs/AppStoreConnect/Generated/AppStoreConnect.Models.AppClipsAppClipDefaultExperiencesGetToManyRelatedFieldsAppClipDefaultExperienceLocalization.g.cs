
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipDefaultExperienceLocalization
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
    public static class AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipDefaultExperienceLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipDefaultExperienceLocalization value)
        {
            return value switch
            {
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipDefaultExperienceLocalization.AppClipDefaultExperience => "appClipDefaultExperience",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipDefaultExperienceLocalization.AppClipHeaderImage => "appClipHeaderImage",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipDefaultExperienceLocalization.Locale => "locale",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipDefaultExperienceLocalization.Subtitle => "subtitle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipDefaultExperienceLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperience" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipDefaultExperienceLocalization.AppClipDefaultExperience,
                "appClipHeaderImage" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipDefaultExperienceLocalization.AppClipHeaderImage,
                "locale" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipDefaultExperienceLocalization.Locale,
                "subtitle" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipDefaultExperienceLocalization.Subtitle,
                _ => null,
            };
        }
    }
}