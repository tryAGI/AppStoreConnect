
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AndroidToIosAppMappingDetailsGetInstanceFieldsAndroidToIosAppMappingDetail
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
    public static class AndroidToIosAppMappingDetailsGetInstanceFieldsAndroidToIosAppMappingDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AndroidToIosAppMappingDetailsGetInstanceFieldsAndroidToIosAppMappingDetail value)
        {
            return value switch
            {
                AndroidToIosAppMappingDetailsGetInstanceFieldsAndroidToIosAppMappingDetail.AppSigningKeyPublicCertificateSha256Fingerprints => "appSigningKeyPublicCertificateSha256Fingerprints",
                AndroidToIosAppMappingDetailsGetInstanceFieldsAndroidToIosAppMappingDetail.PackageName => "packageName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AndroidToIosAppMappingDetailsGetInstanceFieldsAndroidToIosAppMappingDetail? ToEnum(string value)
        {
            return value switch
            {
                "appSigningKeyPublicCertificateSha256Fingerprints" => AndroidToIosAppMappingDetailsGetInstanceFieldsAndroidToIosAppMappingDetail.AppSigningKeyPublicCertificateSha256Fingerprints,
                "packageName" => AndroidToIosAppMappingDetailsGetInstanceFieldsAndroidToIosAppMappingDetail.PackageName,
                _ => null,
            };
        }
    }
}