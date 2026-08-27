
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppStoreVersionsGetToManyRelatedFieldsAlternativeDistributionPackage
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
    public static class AppsAppStoreVersionsGetToManyRelatedFieldsAlternativeDistributionPackageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppStoreVersionsGetToManyRelatedFieldsAlternativeDistributionPackage value)
        {
            return value switch
            {
                AppsAppStoreVersionsGetToManyRelatedFieldsAlternativeDistributionPackage.SourceFileChecksum => "sourceFileChecksum",
                AppsAppStoreVersionsGetToManyRelatedFieldsAlternativeDistributionPackage.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppStoreVersionsGetToManyRelatedFieldsAlternativeDistributionPackage? ToEnum(string value)
        {
            return value switch
            {
                "sourceFileChecksum" => AppsAppStoreVersionsGetToManyRelatedFieldsAlternativeDistributionPackage.SourceFileChecksum,
                "versions" => AppsAppStoreVersionsGetToManyRelatedFieldsAlternativeDistributionPackage.Versions,
                _ => null,
            };
        }
    }
}