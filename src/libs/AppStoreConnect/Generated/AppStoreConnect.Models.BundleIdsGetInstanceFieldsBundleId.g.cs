
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BundleIdsGetInstanceFieldsBundleId
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
        Identifier,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        Platform,
        /// <summary>
        /// 
        /// </summary>
        Profiles,
        /// <summary>
        /// 
        /// </summary>
        SeedId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BundleIdsGetInstanceFieldsBundleIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BundleIdsGetInstanceFieldsBundleId value)
        {
            return value switch
            {
                BundleIdsGetInstanceFieldsBundleId.App => "app",
                BundleIdsGetInstanceFieldsBundleId.BundleIdCapabilities => "bundleIdCapabilities",
                BundleIdsGetInstanceFieldsBundleId.Identifier => "identifier",
                BundleIdsGetInstanceFieldsBundleId.Name => "name",
                BundleIdsGetInstanceFieldsBundleId.Platform => "platform",
                BundleIdsGetInstanceFieldsBundleId.Profiles => "profiles",
                BundleIdsGetInstanceFieldsBundleId.SeedId => "seedId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BundleIdsGetInstanceFieldsBundleId? ToEnum(string value)
        {
            return value switch
            {
                "app" => BundleIdsGetInstanceFieldsBundleId.App,
                "bundleIdCapabilities" => BundleIdsGetInstanceFieldsBundleId.BundleIdCapabilities,
                "identifier" => BundleIdsGetInstanceFieldsBundleId.Identifier,
                "name" => BundleIdsGetInstanceFieldsBundleId.Name,
                "platform" => BundleIdsGetInstanceFieldsBundleId.Platform,
                "profiles" => BundleIdsGetInstanceFieldsBundleId.Profiles,
                "seedId" => BundleIdsGetInstanceFieldsBundleId.SeedId,
                _ => null,
            };
        }
    }
}