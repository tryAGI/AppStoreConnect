
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CertificatesGetCollectionFieldsPassTypeId
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
    public static class CertificatesGetCollectionFieldsPassTypeIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CertificatesGetCollectionFieldsPassTypeId value)
        {
            return value switch
            {
                CertificatesGetCollectionFieldsPassTypeId.Certificates => "certificates",
                CertificatesGetCollectionFieldsPassTypeId.Identifier => "identifier",
                CertificatesGetCollectionFieldsPassTypeId.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CertificatesGetCollectionFieldsPassTypeId? ToEnum(string value)
        {
            return value switch
            {
                "certificates" => CertificatesGetCollectionFieldsPassTypeId.Certificates,
                "identifier" => CertificatesGetCollectionFieldsPassTypeId.Identifier,
                "name" => CertificatesGetCollectionFieldsPassTypeId.Name,
                _ => null,
            };
        }
    }
}