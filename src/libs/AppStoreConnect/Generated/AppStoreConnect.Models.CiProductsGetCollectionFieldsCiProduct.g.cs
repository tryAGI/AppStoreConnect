
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsGetCollectionFieldsCiProduct
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
    public static class CiProductsGetCollectionFieldsCiProductExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsGetCollectionFieldsCiProduct value)
        {
            return value switch
            {
                CiProductsGetCollectionFieldsCiProduct.AdditionalRepositories => "additionalRepositories",
                CiProductsGetCollectionFieldsCiProduct.App => "app",
                CiProductsGetCollectionFieldsCiProduct.BuildRuns => "buildRuns",
                CiProductsGetCollectionFieldsCiProduct.BundleId => "bundleId",
                CiProductsGetCollectionFieldsCiProduct.CreatedDate => "createdDate",
                CiProductsGetCollectionFieldsCiProduct.Name => "name",
                CiProductsGetCollectionFieldsCiProduct.PrimaryRepositories => "primaryRepositories",
                CiProductsGetCollectionFieldsCiProduct.ProductType => "productType",
                CiProductsGetCollectionFieldsCiProduct.Workflows => "workflows",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsGetCollectionFieldsCiProduct? ToEnum(string value)
        {
            return value switch
            {
                "additionalRepositories" => CiProductsGetCollectionFieldsCiProduct.AdditionalRepositories,
                "app" => CiProductsGetCollectionFieldsCiProduct.App,
                "buildRuns" => CiProductsGetCollectionFieldsCiProduct.BuildRuns,
                "bundleId" => CiProductsGetCollectionFieldsCiProduct.BundleId,
                "createdDate" => CiProductsGetCollectionFieldsCiProduct.CreatedDate,
                "name" => CiProductsGetCollectionFieldsCiProduct.Name,
                "primaryRepositories" => CiProductsGetCollectionFieldsCiProduct.PrimaryRepositories,
                "productType" => CiProductsGetCollectionFieldsCiProduct.ProductType,
                "workflows" => CiProductsGetCollectionFieldsCiProduct.Workflows,
                _ => null,
            };
        }
    }
}