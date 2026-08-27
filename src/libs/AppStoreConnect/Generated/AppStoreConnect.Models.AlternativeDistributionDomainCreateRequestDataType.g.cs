
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlternativeDistributionDomainCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AlternativeDistributionDomains,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlternativeDistributionDomainCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionDomainCreateRequestDataType value)
        {
            return value switch
            {
                AlternativeDistributionDomainCreateRequestDataType.AlternativeDistributionDomains => "alternativeDistributionDomains",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionDomainCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionDomains" => AlternativeDistributionDomainCreateRequestDataType.AlternativeDistributionDomains,
                _ => null,
            };
        }
    }
}