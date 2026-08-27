
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum PassTypeIdsCertificatesGetToManyRelatedFieldsCertificate
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
    public static class PassTypeIdsCertificatesGetToManyRelatedFieldsCertificateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PassTypeIdsCertificatesGetToManyRelatedFieldsCertificate value)
        {
            return value switch
            {
                PassTypeIdsCertificatesGetToManyRelatedFieldsCertificate.Activated => "activated",
                PassTypeIdsCertificatesGetToManyRelatedFieldsCertificate.CertificateContent => "certificateContent",
                PassTypeIdsCertificatesGetToManyRelatedFieldsCertificate.CertificateType => "certificateType",
                PassTypeIdsCertificatesGetToManyRelatedFieldsCertificate.DisplayName => "displayName",
                PassTypeIdsCertificatesGetToManyRelatedFieldsCertificate.ExpirationDate => "expirationDate",
                PassTypeIdsCertificatesGetToManyRelatedFieldsCertificate.Name => "name",
                PassTypeIdsCertificatesGetToManyRelatedFieldsCertificate.PassTypeId => "passTypeId",
                PassTypeIdsCertificatesGetToManyRelatedFieldsCertificate.Platform => "platform",
                PassTypeIdsCertificatesGetToManyRelatedFieldsCertificate.SerialNumber => "serialNumber",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PassTypeIdsCertificatesGetToManyRelatedFieldsCertificate? ToEnum(string value)
        {
            return value switch
            {
                "activated" => PassTypeIdsCertificatesGetToManyRelatedFieldsCertificate.Activated,
                "certificateContent" => PassTypeIdsCertificatesGetToManyRelatedFieldsCertificate.CertificateContent,
                "certificateType" => PassTypeIdsCertificatesGetToManyRelatedFieldsCertificate.CertificateType,
                "displayName" => PassTypeIdsCertificatesGetToManyRelatedFieldsCertificate.DisplayName,
                "expirationDate" => PassTypeIdsCertificatesGetToManyRelatedFieldsCertificate.ExpirationDate,
                "name" => PassTypeIdsCertificatesGetToManyRelatedFieldsCertificate.Name,
                "passTypeId" => PassTypeIdsCertificatesGetToManyRelatedFieldsCertificate.PassTypeId,
                "platform" => PassTypeIdsCertificatesGetToManyRelatedFieldsCertificate.Platform,
                "serialNumber" => PassTypeIdsCertificatesGetToManyRelatedFieldsCertificate.SerialNumber,
                _ => null,
            };
        }
    }
}