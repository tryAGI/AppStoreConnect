
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AlternativeDistributionPackageVersionsVariantsGetToManyRelatedFieldsAlternativeDistributionPackageVariant
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
    public static class AlternativeDistributionPackageVersionsVariantsGetToManyRelatedFieldsAlternativeDistributionPackageVariantExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionPackageVersionsVariantsGetToManyRelatedFieldsAlternativeDistributionPackageVariant value)
        {
            return value switch
            {
                AlternativeDistributionPackageVersionsVariantsGetToManyRelatedFieldsAlternativeDistributionPackageVariant.AlternativeDistributionKeyBlob => "alternativeDistributionKeyBlob",
                AlternativeDistributionPackageVersionsVariantsGetToManyRelatedFieldsAlternativeDistributionPackageVariant.FileChecksum => "fileChecksum",
                AlternativeDistributionPackageVersionsVariantsGetToManyRelatedFieldsAlternativeDistributionPackageVariant.Url => "url",
                AlternativeDistributionPackageVersionsVariantsGetToManyRelatedFieldsAlternativeDistributionPackageVariant.UrlExpirationDate => "urlExpirationDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionPackageVersionsVariantsGetToManyRelatedFieldsAlternativeDistributionPackageVariant? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionKeyBlob" => AlternativeDistributionPackageVersionsVariantsGetToManyRelatedFieldsAlternativeDistributionPackageVariant.AlternativeDistributionKeyBlob,
                "fileChecksum" => AlternativeDistributionPackageVersionsVariantsGetToManyRelatedFieldsAlternativeDistributionPackageVariant.FileChecksum,
                "url" => AlternativeDistributionPackageVersionsVariantsGetToManyRelatedFieldsAlternativeDistributionPackageVariant.Url,
                "urlExpirationDate" => AlternativeDistributionPackageVersionsVariantsGetToManyRelatedFieldsAlternativeDistributionPackageVariant.UrlExpirationDate,
                _ => null,
            };
        }
    }
}