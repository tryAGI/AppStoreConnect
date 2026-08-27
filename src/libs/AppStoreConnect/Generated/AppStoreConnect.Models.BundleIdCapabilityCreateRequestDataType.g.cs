
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BundleIdCapabilityCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        BundleIdCapabilities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BundleIdCapabilityCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BundleIdCapabilityCreateRequestDataType value)
        {
            return value switch
            {
                BundleIdCapabilityCreateRequestDataType.BundleIdCapabilities => "bundleIdCapabilities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BundleIdCapabilityCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "bundleIdCapabilities" => BundleIdCapabilityCreateRequestDataType.BundleIdCapabilities,
                _ => null,
            };
        }
    }
}