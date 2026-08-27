
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVersion
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
    public static class AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVersion value)
        {
            return value switch
            {
                AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVersion.Deltas => "deltas",
                AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVersion.FileChecksum => "fileChecksum",
                AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVersion.State => "state",
                AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVersion.Url => "url",
                AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVersion.UrlExpirationDate => "urlExpirationDate",
                AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVersion.Variants => "variants",
                AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVersion.AlternativeDistributionPackage,
                "deltas" => AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVersion.Deltas,
                "fileChecksum" => AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVersion.FileChecksum,
                "state" => AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVersion.State,
                "url" => AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVersion.Url,
                "urlExpirationDate" => AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVersion.UrlExpirationDate,
                "variants" => AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVersion.Variants,
                "version" => AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVersion.Version,
                _ => null,
            };
        }
    }
}