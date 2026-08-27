
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsInAppPurchasesV2GetToManyRelatedFieldsPromotedPurchase
    {
        /// <summary>
        ///
        /// </summary>
        Enabled,
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseV2,
        /// <summary>
        ///
        /// </summary>
        State,
        /// <summary>
        ///
        /// </summary>
        Subscription,
        /// <summary>
        ///
        /// </summary>
        VisibleForAllUsers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsInAppPurchasesV2GetToManyRelatedFieldsPromotedPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsInAppPurchasesV2GetToManyRelatedFieldsPromotedPurchase value)
        {
            return value switch
            {
                AppsInAppPurchasesV2GetToManyRelatedFieldsPromotedPurchase.Enabled => "enabled",
                AppsInAppPurchasesV2GetToManyRelatedFieldsPromotedPurchase.InAppPurchaseV2 => "inAppPurchaseV2",
                AppsInAppPurchasesV2GetToManyRelatedFieldsPromotedPurchase.State => "state",
                AppsInAppPurchasesV2GetToManyRelatedFieldsPromotedPurchase.Subscription => "subscription",
                AppsInAppPurchasesV2GetToManyRelatedFieldsPromotedPurchase.VisibleForAllUsers => "visibleForAllUsers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsInAppPurchasesV2GetToManyRelatedFieldsPromotedPurchase? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => AppsInAppPurchasesV2GetToManyRelatedFieldsPromotedPurchase.Enabled,
                "inAppPurchaseV2" => AppsInAppPurchasesV2GetToManyRelatedFieldsPromotedPurchase.InAppPurchaseV2,
                "state" => AppsInAppPurchasesV2GetToManyRelatedFieldsPromotedPurchase.State,
                "subscription" => AppsInAppPurchasesV2GetToManyRelatedFieldsPromotedPurchase.Subscription,
                "visibleForAllUsers" => AppsInAppPurchasesV2GetToManyRelatedFieldsPromotedPurchase.VisibleForAllUsers,
                _ => null,
            };
        }
    }
}