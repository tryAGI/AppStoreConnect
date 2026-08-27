
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ProfilesGetInstanceFieldsCertificate
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
    public static class ProfilesGetInstanceFieldsCertificateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfilesGetInstanceFieldsCertificate value)
        {
            return value switch
            {
                ProfilesGetInstanceFieldsCertificate.Activated => "activated",
                ProfilesGetInstanceFieldsCertificate.CertificateContent => "certificateContent",
                ProfilesGetInstanceFieldsCertificate.CertificateType => "certificateType",
                ProfilesGetInstanceFieldsCertificate.DisplayName => "displayName",
                ProfilesGetInstanceFieldsCertificate.ExpirationDate => "expirationDate",
                ProfilesGetInstanceFieldsCertificate.Name => "name",
                ProfilesGetInstanceFieldsCertificate.PassTypeId => "passTypeId",
                ProfilesGetInstanceFieldsCertificate.Platform => "platform",
                ProfilesGetInstanceFieldsCertificate.SerialNumber => "serialNumber",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfilesGetInstanceFieldsCertificate? ToEnum(string value)
        {
            return value switch
            {
                "activated" => ProfilesGetInstanceFieldsCertificate.Activated,
                "certificateContent" => ProfilesGetInstanceFieldsCertificate.CertificateContent,
                "certificateType" => ProfilesGetInstanceFieldsCertificate.CertificateType,
                "displayName" => ProfilesGetInstanceFieldsCertificate.DisplayName,
                "expirationDate" => ProfilesGetInstanceFieldsCertificate.ExpirationDate,
                "name" => ProfilesGetInstanceFieldsCertificate.Name,
                "passTypeId" => ProfilesGetInstanceFieldsCertificate.PassTypeId,
                "platform" => ProfilesGetInstanceFieldsCertificate.Platform,
                "serialNumber" => ProfilesGetInstanceFieldsCertificate.SerialNumber,
                _ => null,
            };
        }
    }
}