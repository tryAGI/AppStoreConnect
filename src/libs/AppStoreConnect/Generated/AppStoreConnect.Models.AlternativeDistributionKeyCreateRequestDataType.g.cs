
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AlternativeDistributionKeyCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        AlternativeDistributionKeys,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlternativeDistributionKeyCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionKeyCreateRequestDataType value)
        {
            return value switch
            {
                AlternativeDistributionKeyCreateRequestDataType.AlternativeDistributionKeys => "alternativeDistributionKeys",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionKeyCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionKeys" => AlternativeDistributionKeyCreateRequestDataType.AlternativeDistributionKeys,
                _ => null,
            };
        }
    }
}