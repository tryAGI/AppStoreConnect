
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsGetInstanceIncludeItem
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
    public static class CiProductsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsGetInstanceIncludeItem value)
        {
            return value switch
            {
                CiProductsGetInstanceIncludeItem.App => "app",
                CiProductsGetInstanceIncludeItem.BundleId => "bundleId",
                CiProductsGetInstanceIncludeItem.PrimaryRepositories => "primaryRepositories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => CiProductsGetInstanceIncludeItem.App,
                "bundleId" => CiProductsGetInstanceIncludeItem.BundleId,
                "primaryRepositories" => CiProductsGetInstanceIncludeItem.PrimaryRepositories,
                _ => null,
            };
        }
    }
}