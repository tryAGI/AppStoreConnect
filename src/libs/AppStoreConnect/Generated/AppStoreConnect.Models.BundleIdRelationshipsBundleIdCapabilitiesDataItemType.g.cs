
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BundleIdRelationshipsBundleIdCapabilitiesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        BundleIdCapabilities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BundleIdRelationshipsBundleIdCapabilitiesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BundleIdRelationshipsBundleIdCapabilitiesDataItemType value)
        {
            return value switch
            {
                BundleIdRelationshipsBundleIdCapabilitiesDataItemType.BundleIdCapabilities => "bundleIdCapabilities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BundleIdRelationshipsBundleIdCapabilitiesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "bundleIdCapabilities" => BundleIdRelationshipsBundleIdCapabilitiesDataItemType.BundleIdCapabilities,
                _ => null,
            };
        }
    }
}