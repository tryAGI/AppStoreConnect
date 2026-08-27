
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipDefaultExperienceLocalizationCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipDefaultExperienceLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipDefaultExperienceLocalizationCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperienceLocalizationCreateRequestDataType value)
        {
            return value switch
            {
                AppClipDefaultExperienceLocalizationCreateRequestDataType.AppClipDefaultExperienceLocalizations => "appClipDefaultExperienceLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperienceLocalizationCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperienceLocalizations" => AppClipDefaultExperienceLocalizationCreateRequestDataType.AppClipDefaultExperienceLocalizations,
                _ => null,
            };
        }
    }
}