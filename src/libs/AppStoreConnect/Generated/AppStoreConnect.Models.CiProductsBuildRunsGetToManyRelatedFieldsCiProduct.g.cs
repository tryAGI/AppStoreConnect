
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsBuildRunsGetToManyRelatedFieldsCiProduct
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
    public static class CiProductsBuildRunsGetToManyRelatedFieldsCiProductExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsBuildRunsGetToManyRelatedFieldsCiProduct value)
        {
            return value switch
            {
                CiProductsBuildRunsGetToManyRelatedFieldsCiProduct.AdditionalRepositories => "additionalRepositories",
                CiProductsBuildRunsGetToManyRelatedFieldsCiProduct.App => "app",
                CiProductsBuildRunsGetToManyRelatedFieldsCiProduct.BuildRuns => "buildRuns",
                CiProductsBuildRunsGetToManyRelatedFieldsCiProduct.BundleId => "bundleId",
                CiProductsBuildRunsGetToManyRelatedFieldsCiProduct.CreatedDate => "createdDate",
                CiProductsBuildRunsGetToManyRelatedFieldsCiProduct.Name => "name",
                CiProductsBuildRunsGetToManyRelatedFieldsCiProduct.PrimaryRepositories => "primaryRepositories",
                CiProductsBuildRunsGetToManyRelatedFieldsCiProduct.ProductType => "productType",
                CiProductsBuildRunsGetToManyRelatedFieldsCiProduct.Workflows => "workflows",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsBuildRunsGetToManyRelatedFieldsCiProduct? ToEnum(string value)
        {
            return value switch
            {
                "additionalRepositories" => CiProductsBuildRunsGetToManyRelatedFieldsCiProduct.AdditionalRepositories,
                "app" => CiProductsBuildRunsGetToManyRelatedFieldsCiProduct.App,
                "buildRuns" => CiProductsBuildRunsGetToManyRelatedFieldsCiProduct.BuildRuns,
                "bundleId" => CiProductsBuildRunsGetToManyRelatedFieldsCiProduct.BundleId,
                "createdDate" => CiProductsBuildRunsGetToManyRelatedFieldsCiProduct.CreatedDate,
                "name" => CiProductsBuildRunsGetToManyRelatedFieldsCiProduct.Name,
                "primaryRepositories" => CiProductsBuildRunsGetToManyRelatedFieldsCiProduct.PrimaryRepositories,
                "productType" => CiProductsBuildRunsGetToManyRelatedFieldsCiProduct.ProductType,
                "workflows" => CiProductsBuildRunsGetToManyRelatedFieldsCiProduct.Workflows,
                _ => null,
            };
        }
    }
}