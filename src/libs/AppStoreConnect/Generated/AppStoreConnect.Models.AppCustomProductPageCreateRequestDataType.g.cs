
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageCreateRequestDataType value)
        {
            return value switch
            {
                AppCustomProductPageCreateRequestDataType.AppCustomProductPages => "appCustomProductPages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPages" => AppCustomProductPageCreateRequestDataType.AppCustomProductPages,
                _ => null,
            };
        }
    }
}