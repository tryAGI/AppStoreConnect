
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionsGetInstanceFieldsAlternativeDistributionPackage
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
    public static class AppStoreVersionsGetInstanceFieldsAlternativeDistributionPackageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsGetInstanceFieldsAlternativeDistributionPackage value)
        {
            return value switch
            {
                AppStoreVersionsGetInstanceFieldsAlternativeDistributionPackage.SourceFileChecksum => "sourceFileChecksum",
                AppStoreVersionsGetInstanceFieldsAlternativeDistributionPackage.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsGetInstanceFieldsAlternativeDistributionPackage? ToEnum(string value)
        {
            return value switch
            {
                "sourceFileChecksum" => AppStoreVersionsGetInstanceFieldsAlternativeDistributionPackage.SourceFileChecksum,
                "versions" => AppStoreVersionsGetInstanceFieldsAlternativeDistributionPackage.Versions,
                _ => null,
            };
        }
    }
}