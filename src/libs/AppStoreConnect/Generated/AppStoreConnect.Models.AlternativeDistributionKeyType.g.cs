
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AlternativeDistributionKeyType
    {
        /// <summary>
        ///
        /// </summary>
        AlternativeDistributionKeys,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlternativeDistributionKeyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionKeyType value)
        {
            return value switch
            {
                AlternativeDistributionKeyType.AlternativeDistributionKeys => "alternativeDistributionKeys",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionKeyType? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionKeys" => AlternativeDistributionKeyType.AlternativeDistributionKeys,
                _ => null,
            };
        }
    }
}