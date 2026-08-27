
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAndroidToIosAppMappingDetailsGetToManyRelatedFieldsAndroidToIosAppMappingDetail
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
    public static class AppsAndroidToIosAppMappingDetailsGetToManyRelatedFieldsAndroidToIosAppMappingDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAndroidToIosAppMappingDetailsGetToManyRelatedFieldsAndroidToIosAppMappingDetail value)
        {
            return value switch
            {
                AppsAndroidToIosAppMappingDetailsGetToManyRelatedFieldsAndroidToIosAppMappingDetail.AppSigningKeyPublicCertificateSha256Fingerprints => "appSigningKeyPublicCertificateSha256Fingerprints",
                AppsAndroidToIosAppMappingDetailsGetToManyRelatedFieldsAndroidToIosAppMappingDetail.PackageName => "packageName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAndroidToIosAppMappingDetailsGetToManyRelatedFieldsAndroidToIosAppMappingDetail? ToEnum(string value)
        {
            return value switch
            {
                "appSigningKeyPublicCertificateSha256Fingerprints" => AppsAndroidToIosAppMappingDetailsGetToManyRelatedFieldsAndroidToIosAppMappingDetail.AppSigningKeyPublicCertificateSha256Fingerprints,
                "packageName" => AppsAndroidToIosAppMappingDetailsGetToManyRelatedFieldsAndroidToIosAppMappingDetail.PackageName,
                _ => null,
            };
        }
    }
}