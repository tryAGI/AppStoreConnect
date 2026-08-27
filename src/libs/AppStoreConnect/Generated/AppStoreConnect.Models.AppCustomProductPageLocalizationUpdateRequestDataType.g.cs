
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageLocalizationUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageLocalizationUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationUpdateRequestDataType value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationUpdateRequestDataType.AppCustomProductPageLocalizations => "appCustomProductPageLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalizations" => AppCustomProductPageLocalizationUpdateRequestDataType.AppCustomProductPageLocalizations,
                _ => null,
            };
        }
    }
}