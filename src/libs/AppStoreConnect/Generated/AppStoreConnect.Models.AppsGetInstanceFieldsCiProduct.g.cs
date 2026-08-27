
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGetInstanceFieldsCiProduct
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
    public static class AppsGetInstanceFieldsCiProductExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetInstanceFieldsCiProduct value)
        {
            return value switch
            {
                AppsGetInstanceFieldsCiProduct.AdditionalRepositories => "additionalRepositories",
                AppsGetInstanceFieldsCiProduct.App => "app",
                AppsGetInstanceFieldsCiProduct.BuildRuns => "buildRuns",
                AppsGetInstanceFieldsCiProduct.BundleId => "bundleId",
                AppsGetInstanceFieldsCiProduct.CreatedDate => "createdDate",
                AppsGetInstanceFieldsCiProduct.Name => "name",
                AppsGetInstanceFieldsCiProduct.PrimaryRepositories => "primaryRepositories",
                AppsGetInstanceFieldsCiProduct.ProductType => "productType",
                AppsGetInstanceFieldsCiProduct.Workflows => "workflows",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetInstanceFieldsCiProduct? ToEnum(string value)
        {
            return value switch
            {
                "additionalRepositories" => AppsGetInstanceFieldsCiProduct.AdditionalRepositories,
                "app" => AppsGetInstanceFieldsCiProduct.App,
                "buildRuns" => AppsGetInstanceFieldsCiProduct.BuildRuns,
                "bundleId" => AppsGetInstanceFieldsCiProduct.BundleId,
                "createdDate" => AppsGetInstanceFieldsCiProduct.CreatedDate,
                "name" => AppsGetInstanceFieldsCiProduct.Name,
                "primaryRepositories" => AppsGetInstanceFieldsCiProduct.PrimaryRepositories,
                "productType" => AppsGetInstanceFieldsCiProduct.ProductType,
                "workflows" => AppsGetInstanceFieldsCiProduct.Workflows,
                _ => null,
            };
        }
    }
}