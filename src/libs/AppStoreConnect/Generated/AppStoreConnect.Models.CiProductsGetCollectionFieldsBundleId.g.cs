
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiProductsGetCollectionFieldsBundleId
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
    public static class CiProductsGetCollectionFieldsBundleIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsGetCollectionFieldsBundleId value)
        {
            return value switch
            {
                CiProductsGetCollectionFieldsBundleId.App => "app",
                CiProductsGetCollectionFieldsBundleId.BundleIdCapabilities => "bundleIdCapabilities",
                CiProductsGetCollectionFieldsBundleId.Identifier => "identifier",
                CiProductsGetCollectionFieldsBundleId.Name => "name",
                CiProductsGetCollectionFieldsBundleId.Platform => "platform",
                CiProductsGetCollectionFieldsBundleId.Profiles => "profiles",
                CiProductsGetCollectionFieldsBundleId.SeedId => "seedId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsGetCollectionFieldsBundleId? ToEnum(string value)
        {
            return value switch
            {
                "app" => CiProductsGetCollectionFieldsBundleId.App,
                "bundleIdCapabilities" => CiProductsGetCollectionFieldsBundleId.BundleIdCapabilities,
                "identifier" => CiProductsGetCollectionFieldsBundleId.Identifier,
                "name" => CiProductsGetCollectionFieldsBundleId.Name,
                "platform" => CiProductsGetCollectionFieldsBundleId.Platform,
                "profiles" => CiProductsGetCollectionFieldsBundleId.Profiles,
                "seedId" => CiProductsGetCollectionFieldsBundleId.SeedId,
                _ => null,
            };
        }
    }
}