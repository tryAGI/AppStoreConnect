
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CertificateCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        Certificates,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CertificateCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CertificateCreateRequestDataType value)
        {
            return value switch
            {
                CertificateCreateRequestDataType.Certificates => "certificates",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CertificateCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "certificates" => CertificateCreateRequestDataType.Certificates,
                _ => null,
            };
        }
    }
}