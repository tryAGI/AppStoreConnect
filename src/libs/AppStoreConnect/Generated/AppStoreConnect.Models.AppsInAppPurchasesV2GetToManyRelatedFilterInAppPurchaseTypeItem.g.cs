
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsInAppPurchasesV2GetToManyRelatedFilterInAppPurchaseTypeItem
    {
        /// <summary>
        ///
        /// </summary>
        Consumable,
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
    public static class AppsInAppPurchasesV2GetToManyRelatedFilterInAppPurchaseTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsInAppPurchasesV2GetToManyRelatedFilterInAppPurchaseTypeItem value)
        {
            return value switch
            {
                AppsInAppPurchasesV2GetToManyRelatedFilterInAppPurchaseTypeItem.Consumable => "CONSUMABLE",
                AppsInAppPurchasesV2GetToManyRelatedFilterInAppPurchaseTypeItem.NonConsumable => "NON_CONSUMABLE",
                AppsInAppPurchasesV2GetToManyRelatedFilterInAppPurchaseTypeItem.NonRenewingSubscription => "NON_RENEWING_SUBSCRIPTION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsInAppPurchasesV2GetToManyRelatedFilterInAppPurchaseTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "CONSUMABLE" => AppsInAppPurchasesV2GetToManyRelatedFilterInAppPurchaseTypeItem.Consumable,
                "NON_CONSUMABLE" => AppsInAppPurchasesV2GetToManyRelatedFilterInAppPurchaseTypeItem.NonConsumable,
                "NON_RENEWING_SUBSCRIPTION" => AppsInAppPurchasesV2GetToManyRelatedFilterInAppPurchaseTypeItem.NonRenewingSubscription,
                _ => null,
            };
        }
    }
}