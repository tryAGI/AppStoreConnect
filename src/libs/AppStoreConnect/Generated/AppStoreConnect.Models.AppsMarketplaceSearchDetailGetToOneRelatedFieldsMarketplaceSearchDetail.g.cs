
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsMarketplaceSearchDetailGetToOneRelatedFieldsMarketplaceSearchDetail
    {
        /// <summary>
        /// 
        /// </summary>
        CatalogUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsMarketplaceSearchDetailGetToOneRelatedFieldsMarketplaceSearchDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsMarketplaceSearchDetailGetToOneRelatedFieldsMarketplaceSearchDetail value)
        {
            return value switch
            {
                AppsMarketplaceSearchDetailGetToOneRelatedFieldsMarketplaceSearchDetail.CatalogUrl => "catalogUrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsMarketplaceSearchDetailGetToOneRelatedFieldsMarketplaceSearchDetail? ToEnum(string value)
        {
            return value switch
            {
                "catalogUrl" => AppsMarketplaceSearchDetailGetToOneRelatedFieldsMarketplaceSearchDetail.CatalogUrl,
                _ => null,
            };
        }
    }
}