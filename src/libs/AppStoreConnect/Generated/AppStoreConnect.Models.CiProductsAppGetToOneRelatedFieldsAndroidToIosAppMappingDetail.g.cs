
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail
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
    public static class CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail value)
        {
            return value switch
            {
                CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail.AppSigningKeyPublicCertificateSha256Fingerprints => "appSigningKeyPublicCertificateSha256Fingerprints",
                CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail.PackageName => "packageName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail? ToEnum(string value)
        {
            return value switch
            {
                "appSigningKeyPublicCertificateSha256Fingerprints" => CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail.AppSigningKeyPublicCertificateSha256Fingerprints,
                "packageName" => CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail.PackageName,
                _ => null,
            };
        }
    }
}