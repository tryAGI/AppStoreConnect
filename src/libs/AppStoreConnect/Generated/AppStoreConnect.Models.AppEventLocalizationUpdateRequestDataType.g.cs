
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventLocalizationUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppEventLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventLocalizationUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationUpdateRequestDataType value)
        {
            return value switch
            {
                AppEventLocalizationUpdateRequestDataType.AppEventLocalizations => "appEventLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appEventLocalizations" => AppEventLocalizationUpdateRequestDataType.AppEventLocalizations,
                _ => null,
            };
        }
    }
}