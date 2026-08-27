
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsGetInstanceFieldsCiProduct
    {
        /// <summary>
        ///
        /// </summary>
        AdditionalRepositories,
        /// <summary>
        ///
        /// </summary>
        App,
        /// <summary>
        ///
        /// </summary>
        BuildRuns,
        /// <summary>
        ///
        /// </summary>
        BundleId,
        /// <summary>
        ///
        /// </summary>
        CreatedDate,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        PrimaryRepositories,
        /// <summary>
        ///
        /// </summary>
        ProductType,
        /// <summary>
        ///
        /// </summary>
        Workflows,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiProductsGetInstanceFieldsCiProductExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsGetInstanceFieldsCiProduct value)
        {
            return value switch
            {
                CiProductsGetInstanceFieldsCiProduct.AdditionalRepositories => "additionalRepositories",
                CiProductsGetInstanceFieldsCiProduct.App => "app",
                CiProductsGetInstanceFieldsCiProduct.BuildRuns => "buildRuns",
                CiProductsGetInstanceFieldsCiProduct.BundleId => "bundleId",
                CiProductsGetInstanceFieldsCiProduct.CreatedDate => "createdDate",
                CiProductsGetInstanceFieldsCiProduct.Name => "name",
                CiProductsGetInstanceFieldsCiProduct.PrimaryRepositories => "primaryRepositories",
                CiProductsGetInstanceFieldsCiProduct.ProductType => "productType",
                CiProductsGetInstanceFieldsCiProduct.Workflows => "workflows",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsGetInstanceFieldsCiProduct? ToEnum(string value)
        {
            return value switch
            {
                "additionalRepositories" => CiProductsGetInstanceFieldsCiProduct.AdditionalRepositories,
                "app" => CiProductsGetInstanceFieldsCiProduct.App,
                "buildRuns" => CiProductsGetInstanceFieldsCiProduct.BuildRuns,
                "bundleId" => CiProductsGetInstanceFieldsCiProduct.BundleId,
                "createdDate" => CiProductsGetInstanceFieldsCiProduct.CreatedDate,
                "name" => CiProductsGetInstanceFieldsCiProduct.Name,
                "primaryRepositories" => CiProductsGetInstanceFieldsCiProduct.PrimaryRepositories,
                "productType" => CiProductsGetInstanceFieldsCiProduct.ProductType,
                "workflows" => CiProductsGetInstanceFieldsCiProduct.Workflows,
                _ => null,
            };
        }
    }
}