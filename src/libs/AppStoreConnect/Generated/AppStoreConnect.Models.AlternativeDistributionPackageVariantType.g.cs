
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlternativeDistributionPackageVariantType
    {
        /// <summary>
        /// 
        /// </summary>
        AlternativeDistributionPackageVariants,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlternativeDistributionPackageVariantTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionPackageVariantType value)
        {
            return value switch
            {
                AlternativeDistributionPackageVariantType.AlternativeDistributionPackageVariants => "alternativeDistributionPackageVariants",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionPackageVariantType? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackageVariants" => AlternativeDistributionPackageVariantType.AlternativeDistributionPackageVariants,
                _ => null,
            };
        }
    }
}