
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsInAppPurchasesGetToManyRelatedSortItem
    {
        /// <summary>
        /// 
        /// </summary>
        MinusinAppPurchaseType,
        /// <summary>
        /// 
        /// </summary>
        MinusproductId,
        /// <summary>
        /// 
        /// </summary>
        MinusreferenceName,
        /// <summary>
        /// 
        /// </summary>
        InAppPurchaseType,
        /// <summary>
        /// 
        /// </summary>
        ProductId,
        /// <summary>
        /// 
        /// </summary>
        ReferenceName,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsInAppPurchasesGetToManyRelatedSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsInAppPurchasesGetToManyRelatedSortItem value)
        {
            return value switch
            {
                AppsInAppPurchasesGetToManyRelatedSortItem.MinusinAppPurchaseType => "-inAppPurchaseType",
                AppsInAppPurchasesGetToManyRelatedSortItem.MinusproductId => "-productId",
                AppsInAppPurchasesGetToManyRelatedSortItem.MinusreferenceName => "-referenceName",
                AppsInAppPurchasesGetToManyRelatedSortItem.InAppPurchaseType => "inAppPurchaseType",
                AppsInAppPurchasesGetToManyRelatedSortItem.ProductId => "productId",
                AppsInAppPurchasesGetToManyRelatedSortItem.ReferenceName => "referenceName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsInAppPurchasesGetToManyRelatedSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-inAppPurchaseType" => AppsInAppPurchasesGetToManyRelatedSortItem.MinusinAppPurchaseType,
                "-productId" => AppsInAppPurchasesGetToManyRelatedSortItem.MinusproductId,
                "-referenceName" => AppsInAppPurchasesGetToManyRelatedSortItem.MinusreferenceName,
                "inAppPurchaseType" => AppsInAppPurchasesGetToManyRelatedSortItem.InAppPurchaseType,
                "productId" => AppsInAppPurchasesGetToManyRelatedSortItem.ProductId,
                "referenceName" => AppsInAppPurchasesGetToManyRelatedSortItem.ReferenceName,
                _ => null,
            };
        }
    }
}