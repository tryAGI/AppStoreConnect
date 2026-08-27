
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGetCollectionFieldsCiProduct
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
    public static class AppsGetCollectionFieldsCiProductExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionFieldsCiProduct value)
        {
            return value switch
            {
                AppsGetCollectionFieldsCiProduct.AdditionalRepositories => "additionalRepositories",
                AppsGetCollectionFieldsCiProduct.App => "app",
                AppsGetCollectionFieldsCiProduct.BuildRuns => "buildRuns",
                AppsGetCollectionFieldsCiProduct.BundleId => "bundleId",
                AppsGetCollectionFieldsCiProduct.CreatedDate => "createdDate",
                AppsGetCollectionFieldsCiProduct.Name => "name",
                AppsGetCollectionFieldsCiProduct.PrimaryRepositories => "primaryRepositories",
                AppsGetCollectionFieldsCiProduct.ProductType => "productType",
                AppsGetCollectionFieldsCiProduct.Workflows => "workflows",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionFieldsCiProduct? ToEnum(string value)
        {
            return value switch
            {
                "additionalRepositories" => AppsGetCollectionFieldsCiProduct.AdditionalRepositories,
                "app" => AppsGetCollectionFieldsCiProduct.App,
                "buildRuns" => AppsGetCollectionFieldsCiProduct.BuildRuns,
                "bundleId" => AppsGetCollectionFieldsCiProduct.BundleId,
                "createdDate" => AppsGetCollectionFieldsCiProduct.CreatedDate,
                "name" => AppsGetCollectionFieldsCiProduct.Name,
                "primaryRepositories" => AppsGetCollectionFieldsCiProduct.PrimaryRepositories,
                "productType" => AppsGetCollectionFieldsCiProduct.ProductType,
                "workflows" => AppsGetCollectionFieldsCiProduct.Workflows,
                _ => null,
            };
        }
    }
}