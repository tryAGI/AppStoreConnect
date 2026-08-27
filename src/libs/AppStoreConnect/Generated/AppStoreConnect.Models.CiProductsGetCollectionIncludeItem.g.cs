
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsGetCollectionIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        App,
        /// <summary>
        ///
        /// </summary>
        BundleId,
        /// <summary>
        ///
        /// </summary>
        PrimaryRepositories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiProductsGetCollectionIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsGetCollectionIncludeItem value)
        {
            return value switch
            {
                CiProductsGetCollectionIncludeItem.App => "app",
                CiProductsGetCollectionIncludeItem.BundleId => "bundleId",
                CiProductsGetCollectionIncludeItem.PrimaryRepositories => "primaryRepositories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsGetCollectionIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => CiProductsGetCollectionIncludeItem.App,
                "bundleId" => CiProductsGetCollectionIncludeItem.BundleId,
                "primaryRepositories" => CiProductsGetCollectionIncludeItem.PrimaryRepositories,
                _ => null,
            };
        }
    }
}