
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AlternativeDistributionPackagesGetInstanceFieldsAlternativeDistributionPackageVersion
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
    public static class AlternativeDistributionPackagesGetInstanceFieldsAlternativeDistributionPackageVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionPackagesGetInstanceFieldsAlternativeDistributionPackageVersion value)
        {
            return value switch
            {
                AlternativeDistributionPackagesGetInstanceFieldsAlternativeDistributionPackageVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                AlternativeDistributionPackagesGetInstanceFieldsAlternativeDistributionPackageVersion.Deltas => "deltas",
                AlternativeDistributionPackagesGetInstanceFieldsAlternativeDistributionPackageVersion.FileChecksum => "fileChecksum",
                AlternativeDistributionPackagesGetInstanceFieldsAlternativeDistributionPackageVersion.State => "state",
                AlternativeDistributionPackagesGetInstanceFieldsAlternativeDistributionPackageVersion.Url => "url",
                AlternativeDistributionPackagesGetInstanceFieldsAlternativeDistributionPackageVersion.UrlExpirationDate => "urlExpirationDate",
                AlternativeDistributionPackagesGetInstanceFieldsAlternativeDistributionPackageVersion.Variants => "variants",
                AlternativeDistributionPackagesGetInstanceFieldsAlternativeDistributionPackageVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionPackagesGetInstanceFieldsAlternativeDistributionPackageVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => AlternativeDistributionPackagesGetInstanceFieldsAlternativeDistributionPackageVersion.AlternativeDistributionPackage,
                "deltas" => AlternativeDistributionPackagesGetInstanceFieldsAlternativeDistributionPackageVersion.Deltas,
                "fileChecksum" => AlternativeDistributionPackagesGetInstanceFieldsAlternativeDistributionPackageVersion.FileChecksum,
                "state" => AlternativeDistributionPackagesGetInstanceFieldsAlternativeDistributionPackageVersion.State,
                "url" => AlternativeDistributionPackagesGetInstanceFieldsAlternativeDistributionPackageVersion.Url,
                "urlExpirationDate" => AlternativeDistributionPackagesGetInstanceFieldsAlternativeDistributionPackageVersion.UrlExpirationDate,
                "variants" => AlternativeDistributionPackagesGetInstanceFieldsAlternativeDistributionPackageVersion.Variants,
                "version" => AlternativeDistributionPackagesGetInstanceFieldsAlternativeDistributionPackageVersion.Version,
                _ => null,
            };
        }
    }
}