
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackage
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
    public static class AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackage value)
        {
            return value switch
            {
                AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackage.SourceFileChecksum => "sourceFileChecksum",
                AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackage.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackage? ToEnum(string value)
        {
            return value switch
            {
                "sourceFileChecksum" => AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackage.SourceFileChecksum,
                "versions" => AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackage.Versions,
                _ => null,
            };
        }
    }
}