
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BundleIdsBundleIdCapabilitiesGetToManyRelatedFieldsBundleIdCapabilitie
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
    public static class BundleIdsBundleIdCapabilitiesGetToManyRelatedFieldsBundleIdCapabilitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BundleIdsBundleIdCapabilitiesGetToManyRelatedFieldsBundleIdCapabilitie value)
        {
            return value switch
            {
                BundleIdsBundleIdCapabilitiesGetToManyRelatedFieldsBundleIdCapabilitie.CapabilityType => "capabilityType",
                BundleIdsBundleIdCapabilitiesGetToManyRelatedFieldsBundleIdCapabilitie.Settings => "settings",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BundleIdsBundleIdCapabilitiesGetToManyRelatedFieldsBundleIdCapabilitie? ToEnum(string value)
        {
            return value switch
            {
                "capabilityType" => BundleIdsBundleIdCapabilitiesGetToManyRelatedFieldsBundleIdCapabilitie.CapabilityType,
                "settings" => BundleIdsBundleIdCapabilitiesGetToManyRelatedFieldsBundleIdCapabilitie.Settings,
                _ => null,
            };
        }
    }
}