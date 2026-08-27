
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsPromotedPurchase
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
    public static class InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsPromotedPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsPromotedPurchase value)
        {
            return value switch
            {
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsPromotedPurchase.Enabled => "enabled",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsPromotedPurchase.InAppPurchaseV2 => "inAppPurchaseV2",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsPromotedPurchase.State => "state",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsPromotedPurchase.Subscription => "subscription",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsPromotedPurchase.VisibleForAllUsers => "visibleForAllUsers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsPromotedPurchase? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsPromotedPurchase.Enabled,
                "inAppPurchaseV2" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsPromotedPurchase.InAppPurchaseV2,
                "state" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsPromotedPurchase.State,
                "subscription" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsPromotedPurchase.Subscription,
                "visibleForAllUsers" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsPromotedPurchase.VisibleForAllUsers,
                _ => null,
            };
        }
    }
}