
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipsAppClipAdvancedExperiencesGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        AppClip,
        /// <summary>
        ///
        /// </summary>
        HeaderImage,
        /// <summary>
        ///
        /// </summary>
        Localizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipsAppClipAdvancedExperiencesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipsAppClipAdvancedExperiencesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedIncludeItem.AppClip => "appClip",
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedIncludeItem.HeaderImage => "headerImage",
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedIncludeItem.Localizations => "localizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipsAppClipAdvancedExperiencesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appClip" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedIncludeItem.AppClip,
                "headerImage" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedIncludeItem.HeaderImage,
                "localizations" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedIncludeItem.Localizations,
                _ => null,
            };
        }
    }
}