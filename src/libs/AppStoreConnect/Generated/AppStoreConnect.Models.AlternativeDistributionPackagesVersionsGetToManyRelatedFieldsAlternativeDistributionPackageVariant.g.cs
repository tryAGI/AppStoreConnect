
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVariant
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
    public static class AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVariantExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVariant value)
        {
            return value switch
            {
                AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVariant.AlternativeDistributionKeyBlob => "alternativeDistributionKeyBlob",
                AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVariant.FileChecksum => "fileChecksum",
                AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVariant.Url => "url",
                AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVariant.UrlExpirationDate => "urlExpirationDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVariant? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionKeyBlob" => AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVariant.AlternativeDistributionKeyBlob,
                "fileChecksum" => AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVariant.FileChecksum,
                "url" => AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVariant.Url,
                "urlExpirationDate" => AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVariant.UrlExpirationDate,
                _ => null,
            };
        }
    }
}