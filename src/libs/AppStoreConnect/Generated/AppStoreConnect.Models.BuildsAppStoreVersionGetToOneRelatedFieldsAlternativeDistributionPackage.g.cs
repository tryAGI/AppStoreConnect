
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage
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
    public static class BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage value)
        {
            return value switch
            {
                BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage.SourceFileChecksum => "sourceFileChecksum",
                BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage? ToEnum(string value)
        {
            return value switch
            {
                "sourceFileChecksum" => BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage.SourceFileChecksum,
                "versions" => BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage.Versions,
                _ => null,
            };
        }
    }
}