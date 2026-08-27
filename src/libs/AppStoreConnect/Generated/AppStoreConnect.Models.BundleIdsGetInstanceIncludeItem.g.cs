
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BundleIdsGetInstanceIncludeItem
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
    public static class BundleIdsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BundleIdsGetInstanceIncludeItem value)
        {
            return value switch
            {
                BundleIdsGetInstanceIncludeItem.App => "app",
                BundleIdsGetInstanceIncludeItem.BundleIdCapabilities => "bundleIdCapabilities",
                BundleIdsGetInstanceIncludeItem.Profiles => "profiles",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BundleIdsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => BundleIdsGetInstanceIncludeItem.App,
                "bundleIdCapabilities" => BundleIdsGetInstanceIncludeItem.BundleIdCapabilities,
                "profiles" => BundleIdsGetInstanceIncludeItem.Profiles,
                _ => null,
            };
        }
    }
}