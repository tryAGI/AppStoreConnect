
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiWorkflowsGetInstanceFieldsCiProduct
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
    public static class CiWorkflowsGetInstanceFieldsCiProductExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowsGetInstanceFieldsCiProduct value)
        {
            return value switch
            {
                CiWorkflowsGetInstanceFieldsCiProduct.AdditionalRepositories => "additionalRepositories",
                CiWorkflowsGetInstanceFieldsCiProduct.App => "app",
                CiWorkflowsGetInstanceFieldsCiProduct.BuildRuns => "buildRuns",
                CiWorkflowsGetInstanceFieldsCiProduct.BundleId => "bundleId",
                CiWorkflowsGetInstanceFieldsCiProduct.CreatedDate => "createdDate",
                CiWorkflowsGetInstanceFieldsCiProduct.Name => "name",
                CiWorkflowsGetInstanceFieldsCiProduct.PrimaryRepositories => "primaryRepositories",
                CiWorkflowsGetInstanceFieldsCiProduct.ProductType => "productType",
                CiWorkflowsGetInstanceFieldsCiProduct.Workflows => "workflows",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowsGetInstanceFieldsCiProduct? ToEnum(string value)
        {
            return value switch
            {
                "additionalRepositories" => CiWorkflowsGetInstanceFieldsCiProduct.AdditionalRepositories,
                "app" => CiWorkflowsGetInstanceFieldsCiProduct.App,
                "buildRuns" => CiWorkflowsGetInstanceFieldsCiProduct.BuildRuns,
                "bundleId" => CiWorkflowsGetInstanceFieldsCiProduct.BundleId,
                "createdDate" => CiWorkflowsGetInstanceFieldsCiProduct.CreatedDate,
                "name" => CiWorkflowsGetInstanceFieldsCiProduct.Name,
                "primaryRepositories" => CiWorkflowsGetInstanceFieldsCiProduct.PrimaryRepositories,
                "productType" => CiWorkflowsGetInstanceFieldsCiProduct.ProductType,
                "workflows" => CiWorkflowsGetInstanceFieldsCiProduct.Workflows,
                _ => null,
            };
        }
    }
}