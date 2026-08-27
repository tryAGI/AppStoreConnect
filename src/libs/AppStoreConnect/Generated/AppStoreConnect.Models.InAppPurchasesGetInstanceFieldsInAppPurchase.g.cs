
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasesGetInstanceFieldsInAppPurchase
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
    public static class InAppPurchasesGetInstanceFieldsInAppPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesGetInstanceFieldsInAppPurchase value)
        {
            return value switch
            {
                InAppPurchasesGetInstanceFieldsInAppPurchase.Apps => "apps",
                InAppPurchasesGetInstanceFieldsInAppPurchase.InAppPurchaseType => "inAppPurchaseType",
                InAppPurchasesGetInstanceFieldsInAppPurchase.ProductId => "productId",
                InAppPurchasesGetInstanceFieldsInAppPurchase.ReferenceName => "referenceName",
                InAppPurchasesGetInstanceFieldsInAppPurchase.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesGetInstanceFieldsInAppPurchase? ToEnum(string value)
        {
            return value switch
            {
                "apps" => InAppPurchasesGetInstanceFieldsInAppPurchase.Apps,
                "inAppPurchaseType" => InAppPurchasesGetInstanceFieldsInAppPurchase.InAppPurchaseType,
                "productId" => InAppPurchasesGetInstanceFieldsInAppPurchase.ProductId,
                "referenceName" => InAppPurchasesGetInstanceFieldsInAppPurchase.ReferenceName,
                "state" => InAppPurchasesGetInstanceFieldsInAppPurchase.State,
                _ => null,
            };
        }
    }
}