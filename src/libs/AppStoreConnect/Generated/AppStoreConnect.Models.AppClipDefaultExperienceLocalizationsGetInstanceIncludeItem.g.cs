
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipDefaultExperienceLocalizationsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        AppClipDefaultExperience,
        /// <summary>
        ///
        /// </summary>
        AppClipHeaderImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipDefaultExperienceLocalizationsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperienceLocalizationsGetInstanceIncludeItem value)
        {
            return value switch
            {
                AppClipDefaultExperienceLocalizationsGetInstanceIncludeItem.AppClipDefaultExperience => "appClipDefaultExperience",
                AppClipDefaultExperienceLocalizationsGetInstanceIncludeItem.AppClipHeaderImage => "appClipHeaderImage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperienceLocalizationsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperience" => AppClipDefaultExperienceLocalizationsGetInstanceIncludeItem.AppClipDefaultExperience,
                "appClipHeaderImage" => AppClipDefaultExperienceLocalizationsGetInstanceIncludeItem.AppClipHeaderImage,
                _ => null,
            };
        }
    }
}