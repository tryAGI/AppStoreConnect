
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppAlternativeDistributionKeyLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AlternativeDistributionKeys,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAlternativeDistributionKeyLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAlternativeDistributionKeyLinkageResponseDataType value)
        {
            return value switch
            {
                AppAlternativeDistributionKeyLinkageResponseDataType.AlternativeDistributionKeys => "alternativeDistributionKeys",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAlternativeDistributionKeyLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionKeys" => AppAlternativeDistributionKeyLinkageResponseDataType.AlternativeDistributionKeys,
                _ => null,
            };
        }
    }
}