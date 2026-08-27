
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlternativeDistributionDomainType
    {
        /// <summary>
        /// 
        /// </summary>
        AlternativeDistributionDomains,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlternativeDistributionDomainTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionDomainType value)
        {
            return value switch
            {
                AlternativeDistributionDomainType.AlternativeDistributionDomains => "alternativeDistributionDomains",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionDomainType? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionDomains" => AlternativeDistributionDomainType.AlternativeDistributionDomains,
                _ => null,
            };
        }
    }
}