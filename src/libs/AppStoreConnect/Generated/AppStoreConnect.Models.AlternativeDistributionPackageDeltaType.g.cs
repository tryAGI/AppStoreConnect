
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AlternativeDistributionPackageDeltaType
    {
        /// <summary>
        ///
        /// </summary>
        AlternativeDistributionPackageDeltas,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlternativeDistributionPackageDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionPackageDeltaType value)
        {
            return value switch
            {
                AlternativeDistributionPackageDeltaType.AlternativeDistributionPackageDeltas => "alternativeDistributionPackageDeltas",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionPackageDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackageDeltas" => AlternativeDistributionPackageDeltaType.AlternativeDistributionPackageDeltas,
                _ => null,
            };
        }
    }
}