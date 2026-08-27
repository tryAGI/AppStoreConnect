
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageDelta
    {
        /// <summary>
        /// 
        /// </summary>
        AlternativeDistributionKeyBlob,
        /// <summary>
        /// 
        /// </summary>
        FileChecksum,
        /// <summary>
        /// 
        /// </summary>
        Url,
        /// <summary>
        /// 
        /// </summary>
        UrlExpirationDate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageDeltaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageDelta value)
        {
            return value switch
            {
                AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageDelta.AlternativeDistributionKeyBlob => "alternativeDistributionKeyBlob",
                AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageDelta.FileChecksum => "fileChecksum",
                AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageDelta.Url => "url",
                AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageDelta.UrlExpirationDate => "urlExpirationDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageDelta? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionKeyBlob" => AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageDelta.AlternativeDistributionKeyBlob,
                "fileChecksum" => AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageDelta.FileChecksum,
                "url" => AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageDelta.Url,
                "urlExpirationDate" => AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageDelta.UrlExpirationDate,
                _ => null,
            };
        }
    }
}