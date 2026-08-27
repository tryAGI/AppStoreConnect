
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BundleIdsGetCollectionFieldsBundleIdCapabilitie
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
    public static class BundleIdsGetCollectionFieldsBundleIdCapabilitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BundleIdsGetCollectionFieldsBundleIdCapabilitie value)
        {
            return value switch
            {
                BundleIdsGetCollectionFieldsBundleIdCapabilitie.CapabilityType => "capabilityType",
                BundleIdsGetCollectionFieldsBundleIdCapabilitie.Settings => "settings",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BundleIdsGetCollectionFieldsBundleIdCapabilitie? ToEnum(string value)
        {
            return value switch
            {
                "capabilityType" => BundleIdsGetCollectionFieldsBundleIdCapabilitie.CapabilityType,
                "settings" => BundleIdsGetCollectionFieldsBundleIdCapabilitie.Settings,
                _ => null,
            };
        }
    }
}