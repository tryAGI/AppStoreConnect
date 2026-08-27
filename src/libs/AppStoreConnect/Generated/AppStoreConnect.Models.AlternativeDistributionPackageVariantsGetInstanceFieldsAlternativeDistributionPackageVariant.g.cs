
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AlternativeDistributionPackageVariantsGetInstanceFieldsAlternativeDistributionPackageVariant
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
    public static class AlternativeDistributionPackageVariantsGetInstanceFieldsAlternativeDistributionPackageVariantExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionPackageVariantsGetInstanceFieldsAlternativeDistributionPackageVariant value)
        {
            return value switch
            {
                AlternativeDistributionPackageVariantsGetInstanceFieldsAlternativeDistributionPackageVariant.AlternativeDistributionKeyBlob => "alternativeDistributionKeyBlob",
                AlternativeDistributionPackageVariantsGetInstanceFieldsAlternativeDistributionPackageVariant.FileChecksum => "fileChecksum",
                AlternativeDistributionPackageVariantsGetInstanceFieldsAlternativeDistributionPackageVariant.Url => "url",
                AlternativeDistributionPackageVariantsGetInstanceFieldsAlternativeDistributionPackageVariant.UrlExpirationDate => "urlExpirationDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionPackageVariantsGetInstanceFieldsAlternativeDistributionPackageVariant? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionKeyBlob" => AlternativeDistributionPackageVariantsGetInstanceFieldsAlternativeDistributionPackageVariant.AlternativeDistributionKeyBlob,
                "fileChecksum" => AlternativeDistributionPackageVariantsGetInstanceFieldsAlternativeDistributionPackageVariant.FileChecksum,
                "url" => AlternativeDistributionPackageVariantsGetInstanceFieldsAlternativeDistributionPackageVariant.Url,
                "urlExpirationDate" => AlternativeDistributionPackageVariantsGetInstanceFieldsAlternativeDistributionPackageVariant.UrlExpirationDate,
                _ => null,
            };
        }
    }
}