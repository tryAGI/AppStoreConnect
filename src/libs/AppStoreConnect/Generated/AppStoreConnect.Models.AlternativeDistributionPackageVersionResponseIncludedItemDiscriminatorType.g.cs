
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AlternativeDistributionPackageVersionResponseIncludedItemDiscriminatorType
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
    public static class AlternativeDistributionPackageVersionResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionPackageVersionResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AlternativeDistributionPackageVersionResponseIncludedItemDiscriminatorType.AlternativeDistributionPackageDeltas => "alternativeDistributionPackageDeltas",
                AlternativeDistributionPackageVersionResponseIncludedItemDiscriminatorType.AlternativeDistributionPackageVariants => "alternativeDistributionPackageVariants",
                AlternativeDistributionPackageVersionResponseIncludedItemDiscriminatorType.AlternativeDistributionPackages => "alternativeDistributionPackages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionPackageVersionResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackageDeltas" => AlternativeDistributionPackageVersionResponseIncludedItemDiscriminatorType.AlternativeDistributionPackageDeltas,
                "alternativeDistributionPackageVariants" => AlternativeDistributionPackageVersionResponseIncludedItemDiscriminatorType.AlternativeDistributionPackageVariants,
                "alternativeDistributionPackages" => AlternativeDistributionPackageVersionResponseIncludedItemDiscriminatorType.AlternativeDistributionPackages,
                _ => null,
            };
        }
    }
}