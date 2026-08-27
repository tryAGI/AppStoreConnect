
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageDelta
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
    public static class AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageDeltaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageDelta value)
        {
            return value switch
            {
                AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageDelta.AlternativeDistributionKeyBlob => "alternativeDistributionKeyBlob",
                AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageDelta.FileChecksum => "fileChecksum",
                AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageDelta.Url => "url",
                AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageDelta.UrlExpirationDate => "urlExpirationDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageDelta? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionKeyBlob" => AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageDelta.AlternativeDistributionKeyBlob,
                "fileChecksum" => AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageDelta.FileChecksum,
                "url" => AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageDelta.Url,
                "urlExpirationDate" => AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageDelta.UrlExpirationDate,
                _ => null,
            };
        }
    }
}