
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CertificatesGetCollectionFieldsCertificate
    {
        /// <summary>
        /// 
        /// </summary>
        Activated,
        /// <summary>
        /// 
        /// </summary>
        CertificateContent,
        /// <summary>
        /// 
        /// </summary>
        CertificateType,
        /// <summary>
        /// 
        /// </summary>
        DisplayName,
        /// <summary>
        /// 
        /// </summary>
        ExpirationDate,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        PassTypeId,
        /// <summary>
        /// 
        /// </summary>
        Platform,
        /// <summary>
        /// 
        /// </summary>
        SerialNumber,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CertificatesGetCollectionFieldsCertificateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CertificatesGetCollectionFieldsCertificate value)
        {
            return value switch
            {
                CertificatesGetCollectionFieldsCertificate.Activated => "activated",
                CertificatesGetCollectionFieldsCertificate.CertificateContent => "certificateContent",
                CertificatesGetCollectionFieldsCertificate.CertificateType => "certificateType",
                CertificatesGetCollectionFieldsCertificate.DisplayName => "displayName",
                CertificatesGetCollectionFieldsCertificate.ExpirationDate => "expirationDate",
                CertificatesGetCollectionFieldsCertificate.Name => "name",
                CertificatesGetCollectionFieldsCertificate.PassTypeId => "passTypeId",
                CertificatesGetCollectionFieldsCertificate.Platform => "platform",
                CertificatesGetCollectionFieldsCertificate.SerialNumber => "serialNumber",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CertificatesGetCollectionFieldsCertificate? ToEnum(string value)
        {
            return value switch
            {
                "activated" => CertificatesGetCollectionFieldsCertificate.Activated,
                "certificateContent" => CertificatesGetCollectionFieldsCertificate.CertificateContent,
                "certificateType" => CertificatesGetCollectionFieldsCertificate.CertificateType,
                "displayName" => CertificatesGetCollectionFieldsCertificate.DisplayName,
                "expirationDate" => CertificatesGetCollectionFieldsCertificate.ExpirationDate,
                "name" => CertificatesGetCollectionFieldsCertificate.Name,
                "passTypeId" => CertificatesGetCollectionFieldsCertificate.PassTypeId,
                "platform" => CertificatesGetCollectionFieldsCertificate.Platform,
                "serialNumber" => CertificatesGetCollectionFieldsCertificate.SerialNumber,
                _ => null,
            };
        }
    }
}