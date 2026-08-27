
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct
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
    public static class CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProductExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct value)
        {
            return value switch
            {
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct.AdditionalRepositories => "additionalRepositories",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct.App => "app",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct.BuildRuns => "buildRuns",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct.BundleId => "bundleId",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct.CreatedDate => "createdDate",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct.Name => "name",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct.PrimaryRepositories => "primaryRepositories",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct.ProductType => "productType",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct.Workflows => "workflows",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct? ToEnum(string value)
        {
            return value switch
            {
                "additionalRepositories" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct.AdditionalRepositories,
                "app" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct.App,
                "buildRuns" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct.BuildRuns,
                "bundleId" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct.BundleId,
                "createdDate" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct.CreatedDate,
                "name" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct.Name,
                "primaryRepositories" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct.PrimaryRepositories,
                "productType" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct.ProductType,
                "workflows" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct.Workflows,
                _ => null,
            };
        }
    }
}