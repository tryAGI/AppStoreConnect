
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CertificatesPassTypeIdGetToOneRelatedFieldsPassTypeId
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
    public static class CertificatesPassTypeIdGetToOneRelatedFieldsPassTypeIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CertificatesPassTypeIdGetToOneRelatedFieldsPassTypeId value)
        {
            return value switch
            {
                CertificatesPassTypeIdGetToOneRelatedFieldsPassTypeId.Certificates => "certificates",
                CertificatesPassTypeIdGetToOneRelatedFieldsPassTypeId.Identifier => "identifier",
                CertificatesPassTypeIdGetToOneRelatedFieldsPassTypeId.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CertificatesPassTypeIdGetToOneRelatedFieldsPassTypeId? ToEnum(string value)
        {
            return value switch
            {
                "certificates" => CertificatesPassTypeIdGetToOneRelatedFieldsPassTypeId.Certificates,
                "identifier" => CertificatesPassTypeIdGetToOneRelatedFieldsPassTypeId.Identifier,
                "name" => CertificatesPassTypeIdGetToOneRelatedFieldsPassTypeId.Name,
                _ => null,
            };
        }
    }
}