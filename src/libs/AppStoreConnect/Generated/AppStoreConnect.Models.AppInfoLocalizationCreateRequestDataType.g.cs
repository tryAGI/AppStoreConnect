
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfoLocalizationCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppInfoLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoLocalizationCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoLocalizationCreateRequestDataType value)
        {
            return value switch
            {
                AppInfoLocalizationCreateRequestDataType.AppInfoLocalizations => "appInfoLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoLocalizationCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appInfoLocalizations" => AppInfoLocalizationCreateRequestDataType.AppInfoLocalizations,
                _ => null,
            };
        }
    }
}