
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCiProductLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        CiProducts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCiProductLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCiProductLinkageResponseDataType value)
        {
            return value switch
            {
                AppCiProductLinkageResponseDataType.CiProducts => "ciProducts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCiProductLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "ciProducts" => AppCiProductLinkageResponseDataType.CiProducts,
                _ => null,
            };
        }
    }
}