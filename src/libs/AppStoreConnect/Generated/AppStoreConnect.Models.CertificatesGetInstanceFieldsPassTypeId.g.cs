
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CertificatesGetInstanceFieldsPassTypeId
    {
        /// <summary>
        ///
        /// </summary>
        Certificates,
        /// <summary>
        ///
        /// </summary>
        Identifier,
        /// <summary>
        ///
        /// </summary>
        Name,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CertificatesGetInstanceFieldsPassTypeIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CertificatesGetInstanceFieldsPassTypeId value)
        {
            return value switch
            {
                CertificatesGetInstanceFieldsPassTypeId.Certificates => "certificates",
                CertificatesGetInstanceFieldsPassTypeId.Identifier => "identifier",
                CertificatesGetInstanceFieldsPassTypeId.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CertificatesGetInstanceFieldsPassTypeId? ToEnum(string value)
        {
            return value switch
            {
                "certificates" => CertificatesGetInstanceFieldsPassTypeId.Certificates,
                "identifier" => CertificatesGetInstanceFieldsPassTypeId.Identifier,
                "name" => CertificatesGetInstanceFieldsPassTypeId.Name,
                _ => null,
            };
        }
    }
}