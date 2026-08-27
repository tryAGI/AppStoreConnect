
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AlternativeDistributionPackageVersionType
    {
        /// <summary>
        ///
        /// </summary>
        AlternativeDistributionPackageVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlternativeDistributionPackageVersionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionPackageVersionType value)
        {
            return value switch
            {
                AlternativeDistributionPackageVersionType.AlternativeDistributionPackageVersions => "alternativeDistributionPackageVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionPackageVersionType? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackageVersions" => AlternativeDistributionPackageVersionType.AlternativeDistributionPackageVersions,
                _ => null,
            };
        }
    }
}