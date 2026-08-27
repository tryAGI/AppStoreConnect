
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipAdvancedExperiencesGetInstanceIncludeItem
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
    public static class AppClipAdvancedExperiencesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperiencesGetInstanceIncludeItem value)
        {
            return value switch
            {
                AppClipAdvancedExperiencesGetInstanceIncludeItem.AppClip => "appClip",
                AppClipAdvancedExperiencesGetInstanceIncludeItem.HeaderImage => "headerImage",
                AppClipAdvancedExperiencesGetInstanceIncludeItem.Localizations => "localizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperiencesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appClip" => AppClipAdvancedExperiencesGetInstanceIncludeItem.AppClip,
                "headerImage" => AppClipAdvancedExperiencesGetInstanceIncludeItem.HeaderImage,
                "localizations" => AppClipAdvancedExperiencesGetInstanceIncludeItem.Localizations,
                _ => null,
            };
        }
    }
}