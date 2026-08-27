
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BundleIdsGetCollectionIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        App,
        /// <summary>
        ///
        /// </summary>
        BundleIdCapabilities,
        /// <summary>
        ///
        /// </summary>
        Profiles,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BundleIdsGetCollectionIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BundleIdsGetCollectionIncludeItem value)
        {
            return value switch
            {
                BundleIdsGetCollectionIncludeItem.App => "app",
                BundleIdsGetCollectionIncludeItem.BundleIdCapabilities => "bundleIdCapabilities",
                BundleIdsGetCollectionIncludeItem.Profiles => "profiles",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BundleIdsGetCollectionIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => BundleIdsGetCollectionIncludeItem.App,
                "bundleIdCapabilities" => BundleIdsGetCollectionIncludeItem.BundleIdCapabilities,
                "profiles" => BundleIdsGetCollectionIncludeItem.Profiles,
                _ => null,
            };
        }
    }
}