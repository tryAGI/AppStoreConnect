
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsCiProductGetToOneRelatedFieldsCiProduct
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
    public static class AppsCiProductGetToOneRelatedFieldsCiProductExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsCiProductGetToOneRelatedFieldsCiProduct value)
        {
            return value switch
            {
                AppsCiProductGetToOneRelatedFieldsCiProduct.AdditionalRepositories => "additionalRepositories",
                AppsCiProductGetToOneRelatedFieldsCiProduct.App => "app",
                AppsCiProductGetToOneRelatedFieldsCiProduct.BuildRuns => "buildRuns",
                AppsCiProductGetToOneRelatedFieldsCiProduct.BundleId => "bundleId",
                AppsCiProductGetToOneRelatedFieldsCiProduct.CreatedDate => "createdDate",
                AppsCiProductGetToOneRelatedFieldsCiProduct.Name => "name",
                AppsCiProductGetToOneRelatedFieldsCiProduct.PrimaryRepositories => "primaryRepositories",
                AppsCiProductGetToOneRelatedFieldsCiProduct.ProductType => "productType",
                AppsCiProductGetToOneRelatedFieldsCiProduct.Workflows => "workflows",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsCiProductGetToOneRelatedFieldsCiProduct? ToEnum(string value)
        {
            return value switch
            {
                "additionalRepositories" => AppsCiProductGetToOneRelatedFieldsCiProduct.AdditionalRepositories,
                "app" => AppsCiProductGetToOneRelatedFieldsCiProduct.App,
                "buildRuns" => AppsCiProductGetToOneRelatedFieldsCiProduct.BuildRuns,
                "bundleId" => AppsCiProductGetToOneRelatedFieldsCiProduct.BundleId,
                "createdDate" => AppsCiProductGetToOneRelatedFieldsCiProduct.CreatedDate,
                "name" => AppsCiProductGetToOneRelatedFieldsCiProduct.Name,
                "primaryRepositories" => AppsCiProductGetToOneRelatedFieldsCiProduct.PrimaryRepositories,
                "productType" => AppsCiProductGetToOneRelatedFieldsCiProduct.ProductType,
                "workflows" => AppsCiProductGetToOneRelatedFieldsCiProduct.Workflows,
                _ => null,
            };
        }
    }
}