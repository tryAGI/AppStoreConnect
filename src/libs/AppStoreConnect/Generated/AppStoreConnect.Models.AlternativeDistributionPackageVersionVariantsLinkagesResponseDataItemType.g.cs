
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AlternativeDistributionPackageVersionVariantsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AlternativeDistributionPackageVariants,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlternativeDistributionPackageVersionVariantsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionPackageVersionVariantsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AlternativeDistributionPackageVersionVariantsLinkagesResponseDataItemType.AlternativeDistributionPackageVariants => "alternativeDistributionPackageVariants",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionPackageVersionVariantsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackageVariants" => AlternativeDistributionPackageVersionVariantsLinkagesResponseDataItemType.AlternativeDistributionPackageVariants,
                _ => null,
            };
        }
    }
}