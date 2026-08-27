
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BundleIdBundleIdCapabilitiesLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        BundleIdCapabilities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BundleIdBundleIdCapabilitiesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BundleIdBundleIdCapabilitiesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                BundleIdBundleIdCapabilitiesLinkagesResponseDataItemType.BundleIdCapabilities => "bundleIdCapabilities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BundleIdBundleIdCapabilitiesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "bundleIdCapabilities" => BundleIdBundleIdCapabilitiesLinkagesResponseDataItemType.BundleIdCapabilities,
                _ => null,
            };
        }
    }
}