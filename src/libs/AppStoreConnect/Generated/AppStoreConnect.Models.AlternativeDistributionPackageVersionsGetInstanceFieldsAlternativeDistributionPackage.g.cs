
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackage
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
    public static class AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackage value)
        {
            return value switch
            {
                AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackage.SourceFileChecksum => "sourceFileChecksum",
                AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackage.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackage? ToEnum(string value)
        {
            return value switch
            {
                "sourceFileChecksum" => AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackage.SourceFileChecksum,
                "versions" => AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackage.Versions,
                _ => null,
            };
        }
    }
}