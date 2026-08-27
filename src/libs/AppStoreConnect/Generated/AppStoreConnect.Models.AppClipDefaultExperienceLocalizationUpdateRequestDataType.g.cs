
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipDefaultExperienceLocalizationUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipDefaultExperienceLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipDefaultExperienceLocalizationUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperienceLocalizationUpdateRequestDataType value)
        {
            return value switch
            {
                AppClipDefaultExperienceLocalizationUpdateRequestDataType.AppClipDefaultExperienceLocalizations => "appClipDefaultExperienceLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperienceLocalizationUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperienceLocalizations" => AppClipDefaultExperienceLocalizationUpdateRequestDataType.AppClipDefaultExperienceLocalizations,
                _ => null,
            };
        }
    }
}