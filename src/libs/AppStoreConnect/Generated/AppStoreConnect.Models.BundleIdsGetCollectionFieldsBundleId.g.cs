
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BundleIdsGetCollectionFieldsBundleId
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
    public static class BundleIdsGetCollectionFieldsBundleIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BundleIdsGetCollectionFieldsBundleId value)
        {
            return value switch
            {
                BundleIdsGetCollectionFieldsBundleId.App => "app",
                BundleIdsGetCollectionFieldsBundleId.BundleIdCapabilities => "bundleIdCapabilities",
                BundleIdsGetCollectionFieldsBundleId.Identifier => "identifier",
                BundleIdsGetCollectionFieldsBundleId.Name => "name",
                BundleIdsGetCollectionFieldsBundleId.Platform => "platform",
                BundleIdsGetCollectionFieldsBundleId.Profiles => "profiles",
                BundleIdsGetCollectionFieldsBundleId.SeedId => "seedId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BundleIdsGetCollectionFieldsBundleId? ToEnum(string value)
        {
            return value switch
            {
                "app" => BundleIdsGetCollectionFieldsBundleId.App,
                "bundleIdCapabilities" => BundleIdsGetCollectionFieldsBundleId.BundleIdCapabilities,
                "identifier" => BundleIdsGetCollectionFieldsBundleId.Identifier,
                "name" => BundleIdsGetCollectionFieldsBundleId.Name,
                "platform" => BundleIdsGetCollectionFieldsBundleId.Platform,
                "profiles" => BundleIdsGetCollectionFieldsBundleId.Profiles,
                "seedId" => BundleIdsGetCollectionFieldsBundleId.SeedId,
                _ => null,
            };
        }
    }
}