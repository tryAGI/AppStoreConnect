
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AlternativeDistributionPackageRelationshipsVersionsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AlternativeDistributionPackageVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlternativeDistributionPackageRelationshipsVersionsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionPackageRelationshipsVersionsDataItemType value)
        {
            return value switch
            {
                AlternativeDistributionPackageRelationshipsVersionsDataItemType.AlternativeDistributionPackageVersions => "alternativeDistributionPackageVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionPackageRelationshipsVersionsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackageVersions" => AlternativeDistributionPackageRelationshipsVersionsDataItemType.AlternativeDistributionPackageVersions,
                _ => null,
            };
        }
    }
}