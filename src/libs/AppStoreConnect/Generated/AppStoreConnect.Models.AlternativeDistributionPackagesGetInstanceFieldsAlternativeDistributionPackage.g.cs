
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlternativeDistributionPackagesGetInstanceFieldsAlternativeDistributionPackage
    {
        /// <summary>
        /// 
        /// </summary>
        SourceFileChecksum,
        /// <summary>
        /// 
        /// </summary>
        Versions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlternativeDistributionPackagesGetInstanceFieldsAlternativeDistributionPackageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionPackagesGetInstanceFieldsAlternativeDistributionPackage value)
        {
            return value switch
            {
                AlternativeDistributionPackagesGetInstanceFieldsAlternativeDistributionPackage.SourceFileChecksum => "sourceFileChecksum",
                AlternativeDistributionPackagesGetInstanceFieldsAlternativeDistributionPackage.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionPackagesGetInstanceFieldsAlternativeDistributionPackage? ToEnum(string value)
        {
            return value switch
            {
                "sourceFileChecksum" => AlternativeDistributionPackagesGetInstanceFieldsAlternativeDistributionPackage.SourceFileChecksum,
                "versions" => AlternativeDistributionPackagesGetInstanceFieldsAlternativeDistributionPackage.Versions,
                _ => null,
            };
        }
    }
}