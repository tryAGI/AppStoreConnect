
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackageDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AlternativeDistributionPackages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackageDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackageDataType value)
        {
            return value switch
            {
                AlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackageDataType.AlternativeDistributionPackages => "alternativeDistributionPackages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackageDataType? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackages" => AlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackageDataType.AlternativeDistributionPackages,
                _ => null,
            };
        }
    }
}