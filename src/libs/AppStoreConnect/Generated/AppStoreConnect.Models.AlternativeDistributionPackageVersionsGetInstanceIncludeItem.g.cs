
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AlternativeDistributionPackageVersionsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        AlternativeDistributionPackage,
        /// <summary>
        ///
        /// </summary>
        Deltas,
        /// <summary>
        ///
        /// </summary>
        Variants,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlternativeDistributionPackageVersionsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionPackageVersionsGetInstanceIncludeItem value)
        {
            return value switch
            {
                AlternativeDistributionPackageVersionsGetInstanceIncludeItem.AlternativeDistributionPackage => "alternativeDistributionPackage",
                AlternativeDistributionPackageVersionsGetInstanceIncludeItem.Deltas => "deltas",
                AlternativeDistributionPackageVersionsGetInstanceIncludeItem.Variants => "variants",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionPackageVersionsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => AlternativeDistributionPackageVersionsGetInstanceIncludeItem.AlternativeDistributionPackage,
                "deltas" => AlternativeDistributionPackageVersionsGetInstanceIncludeItem.Deltas,
                "variants" => AlternativeDistributionPackageVersionsGetInstanceIncludeItem.Variants,
                _ => null,
            };
        }
    }
}