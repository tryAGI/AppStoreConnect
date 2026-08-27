
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AlternativeDistributionPackageVersionRelationshipsDeltasDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AlternativeDistributionPackageDeltas,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlternativeDistributionPackageVersionRelationshipsDeltasDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionPackageVersionRelationshipsDeltasDataItemType value)
        {
            return value switch
            {
                AlternativeDistributionPackageVersionRelationshipsDeltasDataItemType.AlternativeDistributionPackageDeltas => "alternativeDistributionPackageDeltas",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionPackageVersionRelationshipsDeltasDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackageDeltas" => AlternativeDistributionPackageVersionRelationshipsDeltasDataItemType.AlternativeDistributionPackageDeltas,
                _ => null,
            };
        }
    }
}