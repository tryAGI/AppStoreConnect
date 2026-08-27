
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsInAppPurchasesGetToManyRelatedFieldsInAppPurchase
    {
        /// <summary>
        /// 
        /// </summary>
        Apps,
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
        /// <summary>
        /// 
        /// </summary>
        State,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsInAppPurchasesGetToManyRelatedFieldsInAppPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsInAppPurchasesGetToManyRelatedFieldsInAppPurchase value)
        {
            return value switch
            {
                AppsInAppPurchasesGetToManyRelatedFieldsInAppPurchase.Apps => "apps",
                AppsInAppPurchasesGetToManyRelatedFieldsInAppPurchase.InAppPurchaseType => "inAppPurchaseType",
                AppsInAppPurchasesGetToManyRelatedFieldsInAppPurchase.ProductId => "productId",
                AppsInAppPurchasesGetToManyRelatedFieldsInAppPurchase.ReferenceName => "referenceName",
                AppsInAppPurchasesGetToManyRelatedFieldsInAppPurchase.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsInAppPurchasesGetToManyRelatedFieldsInAppPurchase? ToEnum(string value)
        {
            return value switch
            {
                "apps" => AppsInAppPurchasesGetToManyRelatedFieldsInAppPurchase.Apps,
                "inAppPurchaseType" => AppsInAppPurchasesGetToManyRelatedFieldsInAppPurchase.InAppPurchaseType,
                "productId" => AppsInAppPurchasesGetToManyRelatedFieldsInAppPurchase.ProductId,
                "referenceName" => AppsInAppPurchasesGetToManyRelatedFieldsInAppPurchase.ReferenceName,
                "state" => AppsInAppPurchasesGetToManyRelatedFieldsInAppPurchase.State,
                _ => null,
            };
        }
    }
}