
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsPromotedPurchasesGetToManyRelatedFieldsPromotedPurchase
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
    public static class AppsPromotedPurchasesGetToManyRelatedFieldsPromotedPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsPromotedPurchasesGetToManyRelatedFieldsPromotedPurchase value)
        {
            return value switch
            {
                AppsPromotedPurchasesGetToManyRelatedFieldsPromotedPurchase.Enabled => "enabled",
                AppsPromotedPurchasesGetToManyRelatedFieldsPromotedPurchase.InAppPurchaseV2 => "inAppPurchaseV2",
                AppsPromotedPurchasesGetToManyRelatedFieldsPromotedPurchase.State => "state",
                AppsPromotedPurchasesGetToManyRelatedFieldsPromotedPurchase.Subscription => "subscription",
                AppsPromotedPurchasesGetToManyRelatedFieldsPromotedPurchase.VisibleForAllUsers => "visibleForAllUsers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsPromotedPurchasesGetToManyRelatedFieldsPromotedPurchase? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => AppsPromotedPurchasesGetToManyRelatedFieldsPromotedPurchase.Enabled,
                "inAppPurchaseV2" => AppsPromotedPurchasesGetToManyRelatedFieldsPromotedPurchase.InAppPurchaseV2,
                "state" => AppsPromotedPurchasesGetToManyRelatedFieldsPromotedPurchase.State,
                "subscription" => AppsPromotedPurchasesGetToManyRelatedFieldsPromotedPurchase.Subscription,
                "visibleForAllUsers" => AppsPromotedPurchasesGetToManyRelatedFieldsPromotedPurchase.VisibleForAllUsers,
                _ => null,
            };
        }
    }
}