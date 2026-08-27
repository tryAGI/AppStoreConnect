
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackage
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
    public static class AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackage value)
        {
            return value switch
            {
                AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackage.SourceFileChecksum => "sourceFileChecksum",
                AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackage.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackage? ToEnum(string value)
        {
            return value switch
            {
                "sourceFileChecksum" => AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackage.SourceFileChecksum,
                "versions" => AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackage.Versions,
                _ => null,
            };
        }
    }
}