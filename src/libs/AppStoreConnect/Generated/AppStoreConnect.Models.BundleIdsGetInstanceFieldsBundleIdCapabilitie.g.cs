
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BundleIdsGetInstanceFieldsBundleIdCapabilitie
    {
        /// <summary>
        ///
        /// </summary>
        CapabilityType,
        /// <summary>
        ///
        /// </summary>
        Settings,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BundleIdsGetInstanceFieldsBundleIdCapabilitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BundleIdsGetInstanceFieldsBundleIdCapabilitie value)
        {
            return value switch
            {
                BundleIdsGetInstanceFieldsBundleIdCapabilitie.CapabilityType => "capabilityType",
                BundleIdsGetInstanceFieldsBundleIdCapabilitie.Settings => "settings",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BundleIdsGetInstanceFieldsBundleIdCapabilitie? ToEnum(string value)
        {
            return value switch
            {
                "capabilityType" => BundleIdsGetInstanceFieldsBundleIdCapabilitie.CapabilityType,
                "settings" => BundleIdsGetInstanceFieldsBundleIdCapabilitie.Settings,
                _ => null,
            };
        }
    }
}