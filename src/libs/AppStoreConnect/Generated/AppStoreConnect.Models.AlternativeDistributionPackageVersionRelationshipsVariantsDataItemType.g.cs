
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlternativeDistributionPackageVersionRelationshipsVariantsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AlternativeDistributionPackageVariants,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlternativeDistributionPackageVersionRelationshipsVariantsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionPackageVersionRelationshipsVariantsDataItemType value)
        {
            return value switch
            {
                AlternativeDistributionPackageVersionRelationshipsVariantsDataItemType.AlternativeDistributionPackageVariants => "alternativeDistributionPackageVariants",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionPackageVersionRelationshipsVariantsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackageVariants" => AlternativeDistributionPackageVersionRelationshipsVariantsDataItemType.AlternativeDistributionPackageVariants,
                _ => null,
            };
        }
    }
}