
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlternativeDistributionPackagesVersionsGetToManyRelatedIncludeItem
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
    public static class AlternativeDistributionPackagesVersionsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionPackagesVersionsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AlternativeDistributionPackagesVersionsGetToManyRelatedIncludeItem.AlternativeDistributionPackage => "alternativeDistributionPackage",
                AlternativeDistributionPackagesVersionsGetToManyRelatedIncludeItem.Deltas => "deltas",
                AlternativeDistributionPackagesVersionsGetToManyRelatedIncludeItem.Variants => "variants",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionPackagesVersionsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => AlternativeDistributionPackagesVersionsGetToManyRelatedIncludeItem.AlternativeDistributionPackage,
                "deltas" => AlternativeDistributionPackagesVersionsGetToManyRelatedIncludeItem.Deltas,
                "variants" => AlternativeDistributionPackagesVersionsGetToManyRelatedIncludeItem.Variants,
                _ => null,
            };
        }
    }
}