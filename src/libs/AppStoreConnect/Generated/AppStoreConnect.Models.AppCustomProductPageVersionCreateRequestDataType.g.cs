
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageVersionCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageVersionCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageVersionCreateRequestDataType value)
        {
            return value switch
            {
                AppCustomProductPageVersionCreateRequestDataType.AppCustomProductPageVersions => "appCustomProductPageVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageVersionCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageVersions" => AppCustomProductPageVersionCreateRequestDataType.AppCustomProductPageVersions,
                _ => null,
            };
        }
    }
}