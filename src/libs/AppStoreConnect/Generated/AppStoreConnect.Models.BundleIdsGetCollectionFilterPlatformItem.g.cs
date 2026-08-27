
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BundleIdsGetCollectionFilterPlatformItem
    {
        /// <summary>
        ///
        /// </summary>
        Ios,
        /// <summary>
        ///
        /// </summary>
        MacOs,
        /// <summary>
        ///
        /// </summary>
        Universal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BundleIdsGetCollectionFilterPlatformItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BundleIdsGetCollectionFilterPlatformItem value)
        {
            return value switch
            {
                BundleIdsGetCollectionFilterPlatformItem.Ios => "IOS",
                BundleIdsGetCollectionFilterPlatformItem.MacOs => "MAC_OS",
                BundleIdsGetCollectionFilterPlatformItem.Universal => "UNIVERSAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BundleIdsGetCollectionFilterPlatformItem? ToEnum(string value)
        {
            return value switch
            {
                "IOS" => BundleIdsGetCollectionFilterPlatformItem.Ios,
                "MAC_OS" => BundleIdsGetCollectionFilterPlatformItem.MacOs,
                "UNIVERSAL" => BundleIdsGetCollectionFilterPlatformItem.Universal,
                _ => null,
            };
        }
    }
}