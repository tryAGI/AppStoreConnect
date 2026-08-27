
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductType
    {
        /// <summary>
        ///
        /// </summary>
        CiProducts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiProductTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductType value)
        {
            return value switch
            {
                CiProductType.CiProducts => "ciProducts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductType? ToEnum(string value)
        {
            return value switch
            {
                "ciProducts" => CiProductType.CiProducts,
                _ => null,
            };
        }
    }
}