
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AlternativeDistributionPackageVersionsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AlternativeDistributionPackageVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlternativeDistributionPackageVersionsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionPackageVersionsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AlternativeDistributionPackageVersionsLinkagesResponseDataItemType.AlternativeDistributionPackageVersions => "alternativeDistributionPackageVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionPackageVersionsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackageVersions" => AlternativeDistributionPackageVersionsLinkagesResponseDataItemType.AlternativeDistributionPackageVersions,
                _ => null,
            };
        }
    }
}