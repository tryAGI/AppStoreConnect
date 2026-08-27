
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperience
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
    public static class AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperienceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperience value)
        {
            return value switch
            {
                AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperience.Action => "action",
                AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperience.AppClip => "appClip",
                AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperience.BusinessCategory => "businessCategory",
                AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperience.DefaultLanguage => "defaultLanguage",
                AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperience.HeaderImage => "headerImage",
                AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperience.IsPoweredBy => "isPoweredBy",
                AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperience.Link => "link",
                AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperience.Localizations => "localizations",
                AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperience.Place => "place",
                AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperience.PlaceStatus => "placeStatus",
                AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperience.Status => "status",
                AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperience.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperience? ToEnum(string value)
        {
            return value switch
            {
                "action" => AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperience.Action,
                "appClip" => AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperience.AppClip,
                "businessCategory" => AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperience.BusinessCategory,
                "defaultLanguage" => AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperience.DefaultLanguage,
                "headerImage" => AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperience.HeaderImage,
                "isPoweredBy" => AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperience.IsPoweredBy,
                "link" => AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperience.Link,
                "localizations" => AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperience.Localizations,
                "place" => AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperience.Place,
                "placeStatus" => AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperience.PlaceStatus,
                "status" => AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperience.Status,
                "version" => AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperience.Version,
                _ => null,
            };
        }
    }
}