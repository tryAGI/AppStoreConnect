
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsWorkflowsGetToManyRelatedFieldsCiProduct
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
    public static class CiProductsWorkflowsGetToManyRelatedFieldsCiProductExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsWorkflowsGetToManyRelatedFieldsCiProduct value)
        {
            return value switch
            {
                CiProductsWorkflowsGetToManyRelatedFieldsCiProduct.AdditionalRepositories => "additionalRepositories",
                CiProductsWorkflowsGetToManyRelatedFieldsCiProduct.App => "app",
                CiProductsWorkflowsGetToManyRelatedFieldsCiProduct.BuildRuns => "buildRuns",
                CiProductsWorkflowsGetToManyRelatedFieldsCiProduct.BundleId => "bundleId",
                CiProductsWorkflowsGetToManyRelatedFieldsCiProduct.CreatedDate => "createdDate",
                CiProductsWorkflowsGetToManyRelatedFieldsCiProduct.Name => "name",
                CiProductsWorkflowsGetToManyRelatedFieldsCiProduct.PrimaryRepositories => "primaryRepositories",
                CiProductsWorkflowsGetToManyRelatedFieldsCiProduct.ProductType => "productType",
                CiProductsWorkflowsGetToManyRelatedFieldsCiProduct.Workflows => "workflows",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsWorkflowsGetToManyRelatedFieldsCiProduct? ToEnum(string value)
        {
            return value switch
            {
                "additionalRepositories" => CiProductsWorkflowsGetToManyRelatedFieldsCiProduct.AdditionalRepositories,
                "app" => CiProductsWorkflowsGetToManyRelatedFieldsCiProduct.App,
                "buildRuns" => CiProductsWorkflowsGetToManyRelatedFieldsCiProduct.BuildRuns,
                "bundleId" => CiProductsWorkflowsGetToManyRelatedFieldsCiProduct.BundleId,
                "createdDate" => CiProductsWorkflowsGetToManyRelatedFieldsCiProduct.CreatedDate,
                "name" => CiProductsWorkflowsGetToManyRelatedFieldsCiProduct.Name,
                "primaryRepositories" => CiProductsWorkflowsGetToManyRelatedFieldsCiProduct.PrimaryRepositories,
                "productType" => CiProductsWorkflowsGetToManyRelatedFieldsCiProduct.ProductType,
                "workflows" => CiProductsWorkflowsGetToManyRelatedFieldsCiProduct.Workflows,
                _ => null,
            };
        }
    }
}