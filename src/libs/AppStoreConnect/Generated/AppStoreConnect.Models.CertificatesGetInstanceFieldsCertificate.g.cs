
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CertificatesGetInstanceFieldsCertificate
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
    public static class CertificatesGetInstanceFieldsCertificateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CertificatesGetInstanceFieldsCertificate value)
        {
            return value switch
            {
                CertificatesGetInstanceFieldsCertificate.Activated => "activated",
                CertificatesGetInstanceFieldsCertificate.CertificateContent => "certificateContent",
                CertificatesGetInstanceFieldsCertificate.CertificateType => "certificateType",
                CertificatesGetInstanceFieldsCertificate.DisplayName => "displayName",
                CertificatesGetInstanceFieldsCertificate.ExpirationDate => "expirationDate",
                CertificatesGetInstanceFieldsCertificate.Name => "name",
                CertificatesGetInstanceFieldsCertificate.PassTypeId => "passTypeId",
                CertificatesGetInstanceFieldsCertificate.Platform => "platform",
                CertificatesGetInstanceFieldsCertificate.SerialNumber => "serialNumber",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CertificatesGetInstanceFieldsCertificate? ToEnum(string value)
        {
            return value switch
            {
                "activated" => CertificatesGetInstanceFieldsCertificate.Activated,
                "certificateContent" => CertificatesGetInstanceFieldsCertificate.CertificateContent,
                "certificateType" => CertificatesGetInstanceFieldsCertificate.CertificateType,
                "displayName" => CertificatesGetInstanceFieldsCertificate.DisplayName,
                "expirationDate" => CertificatesGetInstanceFieldsCertificate.ExpirationDate,
                "name" => CertificatesGetInstanceFieldsCertificate.Name,
                "passTypeId" => CertificatesGetInstanceFieldsCertificate.PassTypeId,
                "platform" => CertificatesGetInstanceFieldsCertificate.Platform,
                "serialNumber" => CertificatesGetInstanceFieldsCertificate.SerialNumber,
                _ => null,
            };
        }
    }
}