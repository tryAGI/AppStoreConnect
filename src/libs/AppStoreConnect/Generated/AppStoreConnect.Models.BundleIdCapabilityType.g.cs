
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BundleIdCapabilityType
    {
        /// <summary>
        ///
        /// </summary>
        BundleIdCapabilities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BundleIdCapabilityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BundleIdCapabilityType value)
        {
            return value switch
            {
                BundleIdCapabilityType.BundleIdCapabilities => "bundleIdCapabilities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BundleIdCapabilityType? ToEnum(string value)
        {
            return value switch
            {
                "bundleIdCapabilities" => BundleIdCapabilityType.BundleIdCapabilities,
                _ => null,
            };
        }
    }
}