
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CertificatesPassTypeIdGetToOneRelatedFieldsCertificate
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
    public static class CertificatesPassTypeIdGetToOneRelatedFieldsCertificateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CertificatesPassTypeIdGetToOneRelatedFieldsCertificate value)
        {
            return value switch
            {
                CertificatesPassTypeIdGetToOneRelatedFieldsCertificate.Activated => "activated",
                CertificatesPassTypeIdGetToOneRelatedFieldsCertificate.CertificateContent => "certificateContent",
                CertificatesPassTypeIdGetToOneRelatedFieldsCertificate.CertificateType => "certificateType",
                CertificatesPassTypeIdGetToOneRelatedFieldsCertificate.DisplayName => "displayName",
                CertificatesPassTypeIdGetToOneRelatedFieldsCertificate.ExpirationDate => "expirationDate",
                CertificatesPassTypeIdGetToOneRelatedFieldsCertificate.Name => "name",
                CertificatesPassTypeIdGetToOneRelatedFieldsCertificate.PassTypeId => "passTypeId",
                CertificatesPassTypeIdGetToOneRelatedFieldsCertificate.Platform => "platform",
                CertificatesPassTypeIdGetToOneRelatedFieldsCertificate.SerialNumber => "serialNumber",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CertificatesPassTypeIdGetToOneRelatedFieldsCertificate? ToEnum(string value)
        {
            return value switch
            {
                "activated" => CertificatesPassTypeIdGetToOneRelatedFieldsCertificate.Activated,
                "certificateContent" => CertificatesPassTypeIdGetToOneRelatedFieldsCertificate.CertificateContent,
                "certificateType" => CertificatesPassTypeIdGetToOneRelatedFieldsCertificate.CertificateType,
                "displayName" => CertificatesPassTypeIdGetToOneRelatedFieldsCertificate.DisplayName,
                "expirationDate" => CertificatesPassTypeIdGetToOneRelatedFieldsCertificate.ExpirationDate,
                "name" => CertificatesPassTypeIdGetToOneRelatedFieldsCertificate.Name,
                "passTypeId" => CertificatesPassTypeIdGetToOneRelatedFieldsCertificate.PassTypeId,
                "platform" => CertificatesPassTypeIdGetToOneRelatedFieldsCertificate.Platform,
                "serialNumber" => CertificatesPassTypeIdGetToOneRelatedFieldsCertificate.SerialNumber,
                _ => null,
            };
        }
    }
}