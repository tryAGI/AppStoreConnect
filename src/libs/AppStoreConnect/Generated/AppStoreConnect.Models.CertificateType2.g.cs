
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CertificateType2
    {
        /// <summary>
        ///
        /// </summary>
        Certificates,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CertificateType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CertificateType2 value)
        {
            return value switch
            {
                CertificateType2.Certificates => "certificates",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CertificateType2? ToEnum(string value)
        {
            return value switch
            {
                "certificates" => CertificateType2.Certificates,
                _ => null,
            };
        }
    }
}