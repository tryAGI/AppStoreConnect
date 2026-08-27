
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CertificatesGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        PassTypeId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CertificatesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CertificatesGetInstanceIncludeItem value)
        {
            return value switch
            {
                CertificatesGetInstanceIncludeItem.PassTypeId => "passTypeId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CertificatesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "passTypeId" => CertificatesGetInstanceIncludeItem.PassTypeId,
                _ => null,
            };
        }
    }
}