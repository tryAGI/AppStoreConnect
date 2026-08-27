
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGetInstanceFieldsAndroidToIosAppMappingDetail
    {
        /// <summary>
        ///
        /// </summary>
        AppSigningKeyPublicCertificateSha256Fingerprints,
        /// <summary>
        ///
        /// </summary>
        PackageName,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsGetInstanceFieldsAndroidToIosAppMappingDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetInstanceFieldsAndroidToIosAppMappingDetail value)
        {
            return value switch
            {
                AppsGetInstanceFieldsAndroidToIosAppMappingDetail.AppSigningKeyPublicCertificateSha256Fingerprints => "appSigningKeyPublicCertificateSha256Fingerprints",
                AppsGetInstanceFieldsAndroidToIosAppMappingDetail.PackageName => "packageName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetInstanceFieldsAndroidToIosAppMappingDetail? ToEnum(string value)
        {
            return value switch
            {
                "appSigningKeyPublicCertificateSha256Fingerprints" => AppsGetInstanceFieldsAndroidToIosAppMappingDetail.AppSigningKeyPublicCertificateSha256Fingerprints,
                "packageName" => AppsGetInstanceFieldsAndroidToIosAppMappingDetail.PackageName,
                _ => null,
            };
        }
    }
}