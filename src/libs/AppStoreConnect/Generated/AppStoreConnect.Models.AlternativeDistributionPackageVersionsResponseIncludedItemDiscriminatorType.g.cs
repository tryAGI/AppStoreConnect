
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AlternativeDistributionPackageVersionsResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        AlternativeDistributionPackageDeltas,
        /// <summary>
        ///
        /// </summary>
        AlternativeDistributionPackageVariants,
        /// <summary>
        ///
        /// </summary>
        AlternativeDistributionPackages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlternativeDistributionPackageVersionsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionPackageVersionsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AlternativeDistributionPackageVersionsResponseIncludedItemDiscriminatorType.AlternativeDistributionPackageDeltas => "alternativeDistributionPackageDeltas",
                AlternativeDistributionPackageVersionsResponseIncludedItemDiscriminatorType.AlternativeDistributionPackageVariants => "alternativeDistributionPackageVariants",
                AlternativeDistributionPackageVersionsResponseIncludedItemDiscriminatorType.AlternativeDistributionPackages => "alternativeDistributionPackages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionPackageVersionsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackageDeltas" => AlternativeDistributionPackageVersionsResponseIncludedItemDiscriminatorType.AlternativeDistributionPackageDeltas,
                "alternativeDistributionPackageVariants" => AlternativeDistributionPackageVersionsResponseIncludedItemDiscriminatorType.AlternativeDistributionPackageVariants,
                "alternativeDistributionPackages" => AlternativeDistributionPackageVersionsResponseIncludedItemDiscriminatorType.AlternativeDistributionPackages,
                _ => null,
            };
        }
    }
}