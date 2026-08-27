
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventLocalizationCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppEventLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventLocalizationCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationCreateRequestDataType value)
        {
            return value switch
            {
                AppEventLocalizationCreateRequestDataType.AppEventLocalizations => "appEventLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appEventLocalizations" => AppEventLocalizationCreateRequestDataType.AppEventLocalizations,
                _ => null,
            };
        }
    }
}