
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiBuildRunsGetInstanceFieldsCiProduct
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
    public static class CiBuildRunsGetInstanceFieldsCiProductExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunsGetInstanceFieldsCiProduct value)
        {
            return value switch
            {
                CiBuildRunsGetInstanceFieldsCiProduct.AdditionalRepositories => "additionalRepositories",
                CiBuildRunsGetInstanceFieldsCiProduct.App => "app",
                CiBuildRunsGetInstanceFieldsCiProduct.BuildRuns => "buildRuns",
                CiBuildRunsGetInstanceFieldsCiProduct.BundleId => "bundleId",
                CiBuildRunsGetInstanceFieldsCiProduct.CreatedDate => "createdDate",
                CiBuildRunsGetInstanceFieldsCiProduct.Name => "name",
                CiBuildRunsGetInstanceFieldsCiProduct.PrimaryRepositories => "primaryRepositories",
                CiBuildRunsGetInstanceFieldsCiProduct.ProductType => "productType",
                CiBuildRunsGetInstanceFieldsCiProduct.Workflows => "workflows",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunsGetInstanceFieldsCiProduct? ToEnum(string value)
        {
            return value switch
            {
                "additionalRepositories" => CiBuildRunsGetInstanceFieldsCiProduct.AdditionalRepositories,
                "app" => CiBuildRunsGetInstanceFieldsCiProduct.App,
                "buildRuns" => CiBuildRunsGetInstanceFieldsCiProduct.BuildRuns,
                "bundleId" => CiBuildRunsGetInstanceFieldsCiProduct.BundleId,
                "createdDate" => CiBuildRunsGetInstanceFieldsCiProduct.CreatedDate,
                "name" => CiBuildRunsGetInstanceFieldsCiProduct.Name,
                "primaryRepositories" => CiBuildRunsGetInstanceFieldsCiProduct.PrimaryRepositories,
                "productType" => CiBuildRunsGetInstanceFieldsCiProduct.ProductType,
                "workflows" => CiBuildRunsGetInstanceFieldsCiProduct.Workflows,
                _ => null,
            };
        }
    }
}