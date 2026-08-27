
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsInAppPurchasesGetToManyRelatedFilterInAppPurchaseTypeItem
    {
        /// <summary>
        ///
        /// </summary>
        AutomaticallyRenewableSubscription,
        /// <summary>
        ///
        /// </summary>
        Consumable,
        /// <summary>
        ///
        /// </summary>
        FreeSubscription,
        /// <summary>
        ///
        /// </summary>
        NonConsumable,
        /// <summary>
        ///
        /// </summary>
        NonRenewingSubscription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsInAppPurchasesGetToManyRelatedFilterInAppPurchaseTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsInAppPurchasesGetToManyRelatedFilterInAppPurchaseTypeItem value)
        {
            return value switch
            {
                AppsInAppPurchasesGetToManyRelatedFilterInAppPurchaseTypeItem.AutomaticallyRenewableSubscription => "AUTOMATICALLY_RENEWABLE_SUBSCRIPTION",
                AppsInAppPurchasesGetToManyRelatedFilterInAppPurchaseTypeItem.Consumable => "CONSUMABLE",
                AppsInAppPurchasesGetToManyRelatedFilterInAppPurchaseTypeItem.FreeSubscription => "FREE_SUBSCRIPTION",
                AppsInAppPurchasesGetToManyRelatedFilterInAppPurchaseTypeItem.NonConsumable => "NON_CONSUMABLE",
                AppsInAppPurchasesGetToManyRelatedFilterInAppPurchaseTypeItem.NonRenewingSubscription => "NON_RENEWING_SUBSCRIPTION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsInAppPurchasesGetToManyRelatedFilterInAppPurchaseTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "AUTOMATICALLY_RENEWABLE_SUBSCRIPTION" => AppsInAppPurchasesGetToManyRelatedFilterInAppPurchaseTypeItem.AutomaticallyRenewableSubscription,
                "CONSUMABLE" => AppsInAppPurchasesGetToManyRelatedFilterInAppPurchaseTypeItem.Consumable,
                "FREE_SUBSCRIPTION" => AppsInAppPurchasesGetToManyRelatedFilterInAppPurchaseTypeItem.FreeSubscription,
                "NON_CONSUMABLE" => AppsInAppPurchasesGetToManyRelatedFilterInAppPurchaseTypeItem.NonConsumable,
                "NON_RENEWING_SUBSCRIPTION" => AppsInAppPurchasesGetToManyRelatedFilterInAppPurchaseTypeItem.NonRenewingSubscription,
                _ => null,
            };
        }
    }
}