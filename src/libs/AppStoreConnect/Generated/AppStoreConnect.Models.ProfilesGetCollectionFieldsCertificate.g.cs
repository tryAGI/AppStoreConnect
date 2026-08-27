
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProfilesGetCollectionFieldsCertificate
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
    public static class ProfilesGetCollectionFieldsCertificateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfilesGetCollectionFieldsCertificate value)
        {
            return value switch
            {
                ProfilesGetCollectionFieldsCertificate.Activated => "activated",
                ProfilesGetCollectionFieldsCertificate.CertificateContent => "certificateContent",
                ProfilesGetCollectionFieldsCertificate.CertificateType => "certificateType",
                ProfilesGetCollectionFieldsCertificate.DisplayName => "displayName",
                ProfilesGetCollectionFieldsCertificate.ExpirationDate => "expirationDate",
                ProfilesGetCollectionFieldsCertificate.Name => "name",
                ProfilesGetCollectionFieldsCertificate.PassTypeId => "passTypeId",
                ProfilesGetCollectionFieldsCertificate.Platform => "platform",
                ProfilesGetCollectionFieldsCertificate.SerialNumber => "serialNumber",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfilesGetCollectionFieldsCertificate? ToEnum(string value)
        {
            return value switch
            {
                "activated" => ProfilesGetCollectionFieldsCertificate.Activated,
                "certificateContent" => ProfilesGetCollectionFieldsCertificate.CertificateContent,
                "certificateType" => ProfilesGetCollectionFieldsCertificate.CertificateType,
                "displayName" => ProfilesGetCollectionFieldsCertificate.DisplayName,
                "expirationDate" => ProfilesGetCollectionFieldsCertificate.ExpirationDate,
                "name" => ProfilesGetCollectionFieldsCertificate.Name,
                "passTypeId" => ProfilesGetCollectionFieldsCertificate.PassTypeId,
                "platform" => ProfilesGetCollectionFieldsCertificate.Platform,
                "serialNumber" => ProfilesGetCollectionFieldsCertificate.SerialNumber,
                _ => null,
            };
        }
    }
}