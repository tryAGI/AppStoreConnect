
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum MerchantIdsGetInstanceFieldsCertificate
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
    public static class MerchantIdsGetInstanceFieldsCertificateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MerchantIdsGetInstanceFieldsCertificate value)
        {
            return value switch
            {
                MerchantIdsGetInstanceFieldsCertificate.Activated => "activated",
                MerchantIdsGetInstanceFieldsCertificate.CertificateContent => "certificateContent",
                MerchantIdsGetInstanceFieldsCertificate.CertificateType => "certificateType",
                MerchantIdsGetInstanceFieldsCertificate.DisplayName => "displayName",
                MerchantIdsGetInstanceFieldsCertificate.ExpirationDate => "expirationDate",
                MerchantIdsGetInstanceFieldsCertificate.Name => "name",
                MerchantIdsGetInstanceFieldsCertificate.PassTypeId => "passTypeId",
                MerchantIdsGetInstanceFieldsCertificate.Platform => "platform",
                MerchantIdsGetInstanceFieldsCertificate.SerialNumber => "serialNumber",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MerchantIdsGetInstanceFieldsCertificate? ToEnum(string value)
        {
            return value switch
            {
                "activated" => MerchantIdsGetInstanceFieldsCertificate.Activated,
                "certificateContent" => MerchantIdsGetInstanceFieldsCertificate.CertificateContent,
                "certificateType" => MerchantIdsGetInstanceFieldsCertificate.CertificateType,
                "displayName" => MerchantIdsGetInstanceFieldsCertificate.DisplayName,
                "expirationDate" => MerchantIdsGetInstanceFieldsCertificate.ExpirationDate,
                "name" => MerchantIdsGetInstanceFieldsCertificate.Name,
                "passTypeId" => MerchantIdsGetInstanceFieldsCertificate.PassTypeId,
                "platform" => MerchantIdsGetInstanceFieldsCertificate.Platform,
                "serialNumber" => MerchantIdsGetInstanceFieldsCertificate.SerialNumber,
                _ => null,
            };
        }
    }
}