
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasesV2PromotedPurchaseGetToOneRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchaseV2,
        /// <summary>
        /// 
        /// </summary>
        Subscription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasesV2PromotedPurchaseGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2PromotedPurchaseGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedIncludeItem.InAppPurchaseV2 => "inAppPurchaseV2",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedIncludeItem.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2PromotedPurchaseGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseV2" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedIncludeItem.InAppPurchaseV2,
                "subscription" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedIncludeItem.Subscription,
                _ => null,
            };
        }
    }
}