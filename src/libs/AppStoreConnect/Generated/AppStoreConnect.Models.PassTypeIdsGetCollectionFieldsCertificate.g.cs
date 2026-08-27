
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum PassTypeIdsGetCollectionFieldsCertificate
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
    public static class PassTypeIdsGetCollectionFieldsCertificateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PassTypeIdsGetCollectionFieldsCertificate value)
        {
            return value switch
            {
                PassTypeIdsGetCollectionFieldsCertificate.Activated => "activated",
                PassTypeIdsGetCollectionFieldsCertificate.CertificateContent => "certificateContent",
                PassTypeIdsGetCollectionFieldsCertificate.CertificateType => "certificateType",
                PassTypeIdsGetCollectionFieldsCertificate.DisplayName => "displayName",
                PassTypeIdsGetCollectionFieldsCertificate.ExpirationDate => "expirationDate",
                PassTypeIdsGetCollectionFieldsCertificate.Name => "name",
                PassTypeIdsGetCollectionFieldsCertificate.PassTypeId => "passTypeId",
                PassTypeIdsGetCollectionFieldsCertificate.Platform => "platform",
                PassTypeIdsGetCollectionFieldsCertificate.SerialNumber => "serialNumber",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PassTypeIdsGetCollectionFieldsCertificate? ToEnum(string value)
        {
            return value switch
            {
                "activated" => PassTypeIdsGetCollectionFieldsCertificate.Activated,
                "certificateContent" => PassTypeIdsGetCollectionFieldsCertificate.CertificateContent,
                "certificateType" => PassTypeIdsGetCollectionFieldsCertificate.CertificateType,
                "displayName" => PassTypeIdsGetCollectionFieldsCertificate.DisplayName,
                "expirationDate" => PassTypeIdsGetCollectionFieldsCertificate.ExpirationDate,
                "name" => PassTypeIdsGetCollectionFieldsCertificate.Name,
                "passTypeId" => PassTypeIdsGetCollectionFieldsCertificate.PassTypeId,
                "platform" => PassTypeIdsGetCollectionFieldsCertificate.Platform,
                "serialNumber" => PassTypeIdsGetCollectionFieldsCertificate.SerialNumber,
                _ => null,
            };
        }
    }
}