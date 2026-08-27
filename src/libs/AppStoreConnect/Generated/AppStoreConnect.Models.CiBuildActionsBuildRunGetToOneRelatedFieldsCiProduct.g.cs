
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct
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
    public static class CiBuildActionsBuildRunGetToOneRelatedFieldsCiProductExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct value)
        {
            return value switch
            {
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct.AdditionalRepositories => "additionalRepositories",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct.App => "app",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct.BuildRuns => "buildRuns",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct.BundleId => "bundleId",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct.CreatedDate => "createdDate",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct.Name => "name",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct.PrimaryRepositories => "primaryRepositories",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct.ProductType => "productType",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct.Workflows => "workflows",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct? ToEnum(string value)
        {
            return value switch
            {
                "additionalRepositories" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct.AdditionalRepositories,
                "app" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct.App,
                "buildRuns" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct.BuildRuns,
                "bundleId" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct.BundleId,
                "createdDate" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct.CreatedDate,
                "name" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct.Name,
                "primaryRepositories" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct.PrimaryRepositories,
                "productType" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct.ProductType,
                "workflows" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct.Workflows,
                _ => null,
            };
        }
    }
}