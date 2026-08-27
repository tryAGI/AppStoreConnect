
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductAttributesProductType
    {
        /// <summary>
        ///
        /// </summary>
        App,
        /// <summary>
        ///
        /// </summary>
        Framework,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiProductAttributesProductTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductAttributesProductType value)
        {
            return value switch
            {
                CiProductAttributesProductType.App => "APP",
                CiProductAttributesProductType.Framework => "FRAMEWORK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductAttributesProductType? ToEnum(string value)
        {
            return value switch
            {
                "APP" => CiProductAttributesProductType.App,
                "FRAMEWORK" => CiProductAttributesProductType.Framework,
                _ => null,
            };
        }
    }
}