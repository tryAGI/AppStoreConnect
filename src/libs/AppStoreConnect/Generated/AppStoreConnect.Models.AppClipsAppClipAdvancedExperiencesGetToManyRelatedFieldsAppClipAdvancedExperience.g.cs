
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience
    {
        /// <summary>
        ///
        /// </summary>
        Action,
        /// <summary>
        ///
        /// </summary>
        AppClip,
        /// <summary>
        ///
        /// </summary>
        BusinessCategory,
        /// <summary>
        ///
        /// </summary>
        DefaultLanguage,
        /// <summary>
        ///
        /// </summary>
        HeaderImage,
        /// <summary>
        ///
        /// </summary>
        IsPoweredBy,
        /// <summary>
        ///
        /// </summary>
        Link,
        /// <summary>
        ///
        /// </summary>
        Localizations,
        /// <summary>
        ///
        /// </summary>
        Place,
        /// <summary>
        ///
        /// </summary>
        PlaceStatus,
        /// <summary>
        ///
        /// </summary>
        Status,
        /// <summary>
        ///
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience value)
        {
            return value switch
            {
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience.Action => "action",
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience.AppClip => "appClip",
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience.BusinessCategory => "businessCategory",
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience.DefaultLanguage => "defaultLanguage",
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience.HeaderImage => "headerImage",
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience.IsPoweredBy => "isPoweredBy",
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience.Link => "link",
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience.Localizations => "localizations",
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience.Place => "place",
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience.PlaceStatus => "placeStatus",
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience.Status => "status",
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience? ToEnum(string value)
        {
            return value switch
            {
                "action" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience.Action,
                "appClip" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience.AppClip,
                "businessCategory" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience.BusinessCategory,
                "defaultLanguage" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience.DefaultLanguage,
                "headerImage" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience.HeaderImage,
                "isPoweredBy" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience.IsPoweredBy,
                "link" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience.Link,
                "localizations" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience.Localizations,
                "place" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience.Place,
                "placeStatus" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience.PlaceStatus,
                "status" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience.Status,
                "version" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience.Version,
                _ => null,
            };
        }
    }
}