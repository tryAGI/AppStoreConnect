
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperienceLocalization
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
    public static class AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperienceLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperienceLocalization value)
        {
            return value switch
            {
                AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperienceLocalization.AppClipDefaultExperience => "appClipDefaultExperience",
                AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperienceLocalization.AppClipHeaderImage => "appClipHeaderImage",
                AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperienceLocalization.Locale => "locale",
                AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperienceLocalization.Subtitle => "subtitle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperienceLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperience" => AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperienceLocalization.AppClipDefaultExperience,
                "appClipHeaderImage" => AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperienceLocalization.AppClipHeaderImage,
                "locale" => AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperienceLocalization.Locale,
                "subtitle" => AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperienceLocalization.Subtitle,
                _ => null,
            };
        }
    }
}