
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum PassTypeIdsGetInstanceFieldsCertificate
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
    public static class PassTypeIdsGetInstanceFieldsCertificateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PassTypeIdsGetInstanceFieldsCertificate value)
        {
            return value switch
            {
                PassTypeIdsGetInstanceFieldsCertificate.Activated => "activated",
                PassTypeIdsGetInstanceFieldsCertificate.CertificateContent => "certificateContent",
                PassTypeIdsGetInstanceFieldsCertificate.CertificateType => "certificateType",
                PassTypeIdsGetInstanceFieldsCertificate.DisplayName => "displayName",
                PassTypeIdsGetInstanceFieldsCertificate.ExpirationDate => "expirationDate",
                PassTypeIdsGetInstanceFieldsCertificate.Name => "name",
                PassTypeIdsGetInstanceFieldsCertificate.PassTypeId => "passTypeId",
                PassTypeIdsGetInstanceFieldsCertificate.Platform => "platform",
                PassTypeIdsGetInstanceFieldsCertificate.SerialNumber => "serialNumber",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PassTypeIdsGetInstanceFieldsCertificate? ToEnum(string value)
        {
            return value switch
            {
                "activated" => PassTypeIdsGetInstanceFieldsCertificate.Activated,
                "certificateContent" => PassTypeIdsGetInstanceFieldsCertificate.CertificateContent,
                "certificateType" => PassTypeIdsGetInstanceFieldsCertificate.CertificateType,
                "displayName" => PassTypeIdsGetInstanceFieldsCertificate.DisplayName,
                "expirationDate" => PassTypeIdsGetInstanceFieldsCertificate.ExpirationDate,
                "name" => PassTypeIdsGetInstanceFieldsCertificate.Name,
                "passTypeId" => PassTypeIdsGetInstanceFieldsCertificate.PassTypeId,
                "platform" => PassTypeIdsGetInstanceFieldsCertificate.Platform,
                "serialNumber" => PassTypeIdsGetInstanceFieldsCertificate.SerialNumber,
                _ => null,
            };
        }
    }
}