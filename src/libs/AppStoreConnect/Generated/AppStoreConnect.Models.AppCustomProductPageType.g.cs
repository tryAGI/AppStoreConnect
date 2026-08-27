
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageType
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageType value)
        {
            return value switch
            {
                AppCustomProductPageType.AppCustomProductPages => "appCustomProductPages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPages" => AppCustomProductPageType.AppCustomProductPages,
                _ => null,
            };
        }
    }
}