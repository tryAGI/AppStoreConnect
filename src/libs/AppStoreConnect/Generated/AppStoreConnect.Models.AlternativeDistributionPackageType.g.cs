
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AlternativeDistributionPackageType
    {
        /// <summary>
        ///
        /// </summary>
        AlternativeDistributionPackages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlternativeDistributionPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionPackageType value)
        {
            return value switch
            {
                AlternativeDistributionPackageType.AlternativeDistributionPackages => "alternativeDistributionPackages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionPackageType? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackages" => AlternativeDistributionPackageType.AlternativeDistributionPackages,
                _ => null,
            };
        }
    }
}