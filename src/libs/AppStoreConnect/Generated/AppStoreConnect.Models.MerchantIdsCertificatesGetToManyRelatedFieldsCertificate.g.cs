
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum MerchantIdsCertificatesGetToManyRelatedFieldsCertificate
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
    public static class MerchantIdsCertificatesGetToManyRelatedFieldsCertificateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MerchantIdsCertificatesGetToManyRelatedFieldsCertificate value)
        {
            return value switch
            {
                MerchantIdsCertificatesGetToManyRelatedFieldsCertificate.Activated => "activated",
                MerchantIdsCertificatesGetToManyRelatedFieldsCertificate.CertificateContent => "certificateContent",
                MerchantIdsCertificatesGetToManyRelatedFieldsCertificate.CertificateType => "certificateType",
                MerchantIdsCertificatesGetToManyRelatedFieldsCertificate.DisplayName => "displayName",
                MerchantIdsCertificatesGetToManyRelatedFieldsCertificate.ExpirationDate => "expirationDate",
                MerchantIdsCertificatesGetToManyRelatedFieldsCertificate.Name => "name",
                MerchantIdsCertificatesGetToManyRelatedFieldsCertificate.PassTypeId => "passTypeId",
                MerchantIdsCertificatesGetToManyRelatedFieldsCertificate.Platform => "platform",
                MerchantIdsCertificatesGetToManyRelatedFieldsCertificate.SerialNumber => "serialNumber",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MerchantIdsCertificatesGetToManyRelatedFieldsCertificate? ToEnum(string value)
        {
            return value switch
            {
                "activated" => MerchantIdsCertificatesGetToManyRelatedFieldsCertificate.Activated,
                "certificateContent" => MerchantIdsCertificatesGetToManyRelatedFieldsCertificate.CertificateContent,
                "certificateType" => MerchantIdsCertificatesGetToManyRelatedFieldsCertificate.CertificateType,
                "displayName" => MerchantIdsCertificatesGetToManyRelatedFieldsCertificate.DisplayName,
                "expirationDate" => MerchantIdsCertificatesGetToManyRelatedFieldsCertificate.ExpirationDate,
                "name" => MerchantIdsCertificatesGetToManyRelatedFieldsCertificate.Name,
                "passTypeId" => MerchantIdsCertificatesGetToManyRelatedFieldsCertificate.PassTypeId,
                "platform" => MerchantIdsCertificatesGetToManyRelatedFieldsCertificate.Platform,
                "serialNumber" => MerchantIdsCertificatesGetToManyRelatedFieldsCertificate.SerialNumber,
                _ => null,
            };
        }
    }
}