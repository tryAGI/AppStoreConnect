
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppCustomProductPageUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppCustomProductPages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageUpdateRequestDataType value)
        {
            return value switch
            {
                AppCustomProductPageUpdateRequestDataType.AppCustomProductPages => "appCustomProductPages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPages" => AppCustomProductPageUpdateRequestDataType.AppCustomProductPages,
                _ => null,
            };
        }
    }
}