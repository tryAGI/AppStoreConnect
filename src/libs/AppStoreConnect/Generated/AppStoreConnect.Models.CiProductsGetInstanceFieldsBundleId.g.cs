
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiProductsGetInstanceFieldsBundleId
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
    public static class CiProductsGetInstanceFieldsBundleIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsGetInstanceFieldsBundleId value)
        {
            return value switch
            {
                CiProductsGetInstanceFieldsBundleId.App => "app",
                CiProductsGetInstanceFieldsBundleId.BundleIdCapabilities => "bundleIdCapabilities",
                CiProductsGetInstanceFieldsBundleId.Identifier => "identifier",
                CiProductsGetInstanceFieldsBundleId.Name => "name",
                CiProductsGetInstanceFieldsBundleId.Platform => "platform",
                CiProductsGetInstanceFieldsBundleId.Profiles => "profiles",
                CiProductsGetInstanceFieldsBundleId.SeedId => "seedId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsGetInstanceFieldsBundleId? ToEnum(string value)
        {
            return value switch
            {
                "app" => CiProductsGetInstanceFieldsBundleId.App,
                "bundleIdCapabilities" => CiProductsGetInstanceFieldsBundleId.BundleIdCapabilities,
                "identifier" => CiProductsGetInstanceFieldsBundleId.Identifier,
                "name" => CiProductsGetInstanceFieldsBundleId.Name,
                "platform" => CiProductsGetInstanceFieldsBundleId.Platform,
                "profiles" => CiProductsGetInstanceFieldsBundleId.Profiles,
                "seedId" => CiProductsGetInstanceFieldsBundleId.SeedId,
                _ => null,
            };
        }
    }
}