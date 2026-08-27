
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsAppGetToOneRelatedFieldsCiProduct
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
    public static class CiProductsAppGetToOneRelatedFieldsCiProductExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsAppGetToOneRelatedFieldsCiProduct value)
        {
            return value switch
            {
                CiProductsAppGetToOneRelatedFieldsCiProduct.AdditionalRepositories => "additionalRepositories",
                CiProductsAppGetToOneRelatedFieldsCiProduct.App => "app",
                CiProductsAppGetToOneRelatedFieldsCiProduct.BuildRuns => "buildRuns",
                CiProductsAppGetToOneRelatedFieldsCiProduct.BundleId => "bundleId",
                CiProductsAppGetToOneRelatedFieldsCiProduct.CreatedDate => "createdDate",
                CiProductsAppGetToOneRelatedFieldsCiProduct.Name => "name",
                CiProductsAppGetToOneRelatedFieldsCiProduct.PrimaryRepositories => "primaryRepositories",
                CiProductsAppGetToOneRelatedFieldsCiProduct.ProductType => "productType",
                CiProductsAppGetToOneRelatedFieldsCiProduct.Workflows => "workflows",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsAppGetToOneRelatedFieldsCiProduct? ToEnum(string value)
        {
            return value switch
            {
                "additionalRepositories" => CiProductsAppGetToOneRelatedFieldsCiProduct.AdditionalRepositories,
                "app" => CiProductsAppGetToOneRelatedFieldsCiProduct.App,
                "buildRuns" => CiProductsAppGetToOneRelatedFieldsCiProduct.BuildRuns,
                "bundleId" => CiProductsAppGetToOneRelatedFieldsCiProduct.BundleId,
                "createdDate" => CiProductsAppGetToOneRelatedFieldsCiProduct.CreatedDate,
                "name" => CiProductsAppGetToOneRelatedFieldsCiProduct.Name,
                "primaryRepositories" => CiProductsAppGetToOneRelatedFieldsCiProduct.PrimaryRepositories,
                "productType" => CiProductsAppGetToOneRelatedFieldsCiProduct.ProductType,
                "workflows" => CiProductsAppGetToOneRelatedFieldsCiProduct.Workflows,
                _ => null,
            };
        }
    }
}