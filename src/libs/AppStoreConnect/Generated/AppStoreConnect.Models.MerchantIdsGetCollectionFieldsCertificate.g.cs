
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum MerchantIdsGetCollectionFieldsCertificate
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
    public static class MerchantIdsGetCollectionFieldsCertificateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MerchantIdsGetCollectionFieldsCertificate value)
        {
            return value switch
            {
                MerchantIdsGetCollectionFieldsCertificate.Activated => "activated",
                MerchantIdsGetCollectionFieldsCertificate.CertificateContent => "certificateContent",
                MerchantIdsGetCollectionFieldsCertificate.CertificateType => "certificateType",
                MerchantIdsGetCollectionFieldsCertificate.DisplayName => "displayName",
                MerchantIdsGetCollectionFieldsCertificate.ExpirationDate => "expirationDate",
                MerchantIdsGetCollectionFieldsCertificate.Name => "name",
                MerchantIdsGetCollectionFieldsCertificate.PassTypeId => "passTypeId",
                MerchantIdsGetCollectionFieldsCertificate.Platform => "platform",
                MerchantIdsGetCollectionFieldsCertificate.SerialNumber => "serialNumber",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MerchantIdsGetCollectionFieldsCertificate? ToEnum(string value)
        {
            return value switch
            {
                "activated" => MerchantIdsGetCollectionFieldsCertificate.Activated,
                "certificateContent" => MerchantIdsGetCollectionFieldsCertificate.CertificateContent,
                "certificateType" => MerchantIdsGetCollectionFieldsCertificate.CertificateType,
                "displayName" => MerchantIdsGetCollectionFieldsCertificate.DisplayName,
                "expirationDate" => MerchantIdsGetCollectionFieldsCertificate.ExpirationDate,
                "name" => MerchantIdsGetCollectionFieldsCertificate.Name,
                "passTypeId" => MerchantIdsGetCollectionFieldsCertificate.PassTypeId,
                "platform" => MerchantIdsGetCollectionFieldsCertificate.Platform,
                "serialNumber" => MerchantIdsGetCollectionFieldsCertificate.SerialNumber,
                _ => null,
            };
        }
    }
}