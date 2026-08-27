
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CertificateUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Certificates,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CertificateUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CertificateUpdateRequestDataType value)
        {
            return value switch
            {
                CertificateUpdateRequestDataType.Certificates => "certificates",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CertificateUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "certificates" => CertificateUpdateRequestDataType.Certificates,
                _ => null,
            };
        }
    }
}