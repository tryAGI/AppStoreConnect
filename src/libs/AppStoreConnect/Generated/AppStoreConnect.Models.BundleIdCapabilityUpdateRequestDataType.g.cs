
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BundleIdCapabilityUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        BundleIdCapabilities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BundleIdCapabilityUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BundleIdCapabilityUpdateRequestDataType value)
        {
            return value switch
            {
                BundleIdCapabilityUpdateRequestDataType.BundleIdCapabilities => "bundleIdCapabilities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BundleIdCapabilityUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "bundleIdCapabilities" => BundleIdCapabilityUpdateRequestDataType.BundleIdCapabilities,
                _ => null,
            };
        }
    }
}