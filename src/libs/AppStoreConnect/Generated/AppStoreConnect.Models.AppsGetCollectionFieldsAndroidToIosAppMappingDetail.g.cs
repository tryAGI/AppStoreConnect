
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGetCollectionFieldsAndroidToIosAppMappingDetail
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
    public static class AppsGetCollectionFieldsAndroidToIosAppMappingDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionFieldsAndroidToIosAppMappingDetail value)
        {
            return value switch
            {
                AppsGetCollectionFieldsAndroidToIosAppMappingDetail.AppSigningKeyPublicCertificateSha256Fingerprints => "appSigningKeyPublicCertificateSha256Fingerprints",
                AppsGetCollectionFieldsAndroidToIosAppMappingDetail.PackageName => "packageName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionFieldsAndroidToIosAppMappingDetail? ToEnum(string value)
        {
            return value switch
            {
                "appSigningKeyPublicCertificateSha256Fingerprints" => AppsGetCollectionFieldsAndroidToIosAppMappingDetail.AppSigningKeyPublicCertificateSha256Fingerprints,
                "packageName" => AppsGetCollectionFieldsAndroidToIosAppMappingDetail.PackageName,
                _ => null,
            };
        }
    }
}