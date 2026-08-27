
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProfilesCertificatesGetToManyRelatedFieldsCertificate
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
    public static class ProfilesCertificatesGetToManyRelatedFieldsCertificateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfilesCertificatesGetToManyRelatedFieldsCertificate value)
        {
            return value switch
            {
                ProfilesCertificatesGetToManyRelatedFieldsCertificate.Activated => "activated",
                ProfilesCertificatesGetToManyRelatedFieldsCertificate.CertificateContent => "certificateContent",
                ProfilesCertificatesGetToManyRelatedFieldsCertificate.CertificateType => "certificateType",
                ProfilesCertificatesGetToManyRelatedFieldsCertificate.DisplayName => "displayName",
                ProfilesCertificatesGetToManyRelatedFieldsCertificate.ExpirationDate => "expirationDate",
                ProfilesCertificatesGetToManyRelatedFieldsCertificate.Name => "name",
                ProfilesCertificatesGetToManyRelatedFieldsCertificate.PassTypeId => "passTypeId",
                ProfilesCertificatesGetToManyRelatedFieldsCertificate.Platform => "platform",
                ProfilesCertificatesGetToManyRelatedFieldsCertificate.SerialNumber => "serialNumber",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfilesCertificatesGetToManyRelatedFieldsCertificate? ToEnum(string value)
        {
            return value switch
            {
                "activated" => ProfilesCertificatesGetToManyRelatedFieldsCertificate.Activated,
                "certificateContent" => ProfilesCertificatesGetToManyRelatedFieldsCertificate.CertificateContent,
                "certificateType" => ProfilesCertificatesGetToManyRelatedFieldsCertificate.CertificateType,
                "displayName" => ProfilesCertificatesGetToManyRelatedFieldsCertificate.DisplayName,
                "expirationDate" => ProfilesCertificatesGetToManyRelatedFieldsCertificate.ExpirationDate,
                "name" => ProfilesCertificatesGetToManyRelatedFieldsCertificate.Name,
                "passTypeId" => ProfilesCertificatesGetToManyRelatedFieldsCertificate.PassTypeId,
                "platform" => ProfilesCertificatesGetToManyRelatedFieldsCertificate.Platform,
                "serialNumber" => ProfilesCertificatesGetToManyRelatedFieldsCertificate.SerialNumber,
                _ => null,
            };
        }
    }
}