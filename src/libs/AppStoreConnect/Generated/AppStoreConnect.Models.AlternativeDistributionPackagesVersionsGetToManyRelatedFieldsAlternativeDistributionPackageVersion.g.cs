
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVersion
    {
        /// <summary>
        ///
        /// </summary>
        AlternativeDistributionPackage,
        /// <summary>
        ///
        /// </summary>
        Deltas,
        /// <summary>
        ///
        /// </summary>
        FileChecksum,
        /// <summary>
        ///
        /// </summary>
        State,
        /// <summary>
        ///
        /// </summary>
        Url,
        /// <summary>
        ///
        /// </summary>
        UrlExpirationDate,
        /// <summary>
        ///
        /// </summary>
        Variants,
        /// <summary>
        ///
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVersion value)
        {
            return value switch
            {
                AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVersion.Deltas => "deltas",
                AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVersion.FileChecksum => "fileChecksum",
                AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVersion.State => "state",
                AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVersion.Url => "url",
                AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVersion.UrlExpirationDate => "urlExpirationDate",
                AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVersion.Variants => "variants",
                AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVersion.AlternativeDistributionPackage,
                "deltas" => AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVersion.Deltas,
                "fileChecksum" => AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVersion.FileChecksum,
                "state" => AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVersion.State,
                "url" => AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVersion.Url,
                "urlExpirationDate" => AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVersion.UrlExpirationDate,
                "variants" => AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVersion.Variants,
                "version" => AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVersion.Version,
                _ => null,
            };
        }
    }
}