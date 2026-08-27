
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfoLocalizationUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppInfoLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoLocalizationUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoLocalizationUpdateRequestDataType value)
        {
            return value switch
            {
                AppInfoLocalizationUpdateRequestDataType.AppInfoLocalizations => "appInfoLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoLocalizationUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appInfoLocalizations" => AppInfoLocalizationUpdateRequestDataType.AppInfoLocalizations,
                _ => null,
            };
        }
    }
}