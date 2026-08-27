
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipAdvancedExperienceLocalizationType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipAdvancedExperienceLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAdvancedExperienceLocalizationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceLocalizationType value)
        {
            return value switch
            {
                AppClipAdvancedExperienceLocalizationType.AppClipAdvancedExperienceLocalizations => "appClipAdvancedExperienceLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceLocalizationType? ToEnum(string value)
        {
            return value switch
            {
                "appClipAdvancedExperienceLocalizations" => AppClipAdvancedExperienceLocalizationType.AppClipAdvancedExperienceLocalizations,
                _ => null,
            };
        }
    }
}