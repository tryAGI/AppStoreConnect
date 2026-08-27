
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVariant
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
    public static class AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVariantExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVariant value)
        {
            return value switch
            {
                AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVariant.AlternativeDistributionKeyBlob => "alternativeDistributionKeyBlob",
                AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVariant.FileChecksum => "fileChecksum",
                AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVariant.Url => "url",
                AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVariant.UrlExpirationDate => "urlExpirationDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVariant? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionKeyBlob" => AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVariant.AlternativeDistributionKeyBlob,
                "fileChecksum" => AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVariant.FileChecksum,
                "url" => AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVariant.Url,
                "urlExpirationDate" => AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVariant.UrlExpirationDate,
                _ => null,
            };
        }
    }
}