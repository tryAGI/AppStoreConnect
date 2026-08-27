
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipAdvancedExperienceLocalizationInlineCreateType
    {
        /// <summary>
        ///
        /// </summary>
        AppClipAdvancedExperienceLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAdvancedExperienceLocalizationInlineCreateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceLocalizationInlineCreateType value)
        {
            return value switch
            {
                AppClipAdvancedExperienceLocalizationInlineCreateType.AppClipAdvancedExperienceLocalizations => "appClipAdvancedExperienceLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceLocalizationInlineCreateType? ToEnum(string value)
        {
            return value switch
            {
                "appClipAdvancedExperienceLocalizations" => AppClipAdvancedExperienceLocalizationInlineCreateType.AppClipAdvancedExperienceLocalizations,
                _ => null,
            };
        }
    }
}