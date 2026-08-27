
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AlternativeDistributionPackageVersionDeltasLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AlternativeDistributionPackageDeltas,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlternativeDistributionPackageVersionDeltasLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionPackageVersionDeltasLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AlternativeDistributionPackageVersionDeltasLinkagesResponseDataItemType.AlternativeDistributionPackageDeltas => "alternativeDistributionPackageDeltas",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionPackageVersionDeltasLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackageDeltas" => AlternativeDistributionPackageVersionDeltasLinkagesResponseDataItemType.AlternativeDistributionPackageDeltas,
                _ => null,
            };
        }
    }
}