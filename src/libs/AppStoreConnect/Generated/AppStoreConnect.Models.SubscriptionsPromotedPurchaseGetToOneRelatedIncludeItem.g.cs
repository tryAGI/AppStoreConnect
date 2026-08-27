
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsPromotedPurchaseGetToOneRelatedIncludeItem
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
    public static class SubscriptionsPromotedPurchaseGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsPromotedPurchaseGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                SubscriptionsPromotedPurchaseGetToOneRelatedIncludeItem.InAppPurchaseV2 => "inAppPurchaseV2",
                SubscriptionsPromotedPurchaseGetToOneRelatedIncludeItem.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsPromotedPurchaseGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseV2" => SubscriptionsPromotedPurchaseGetToOneRelatedIncludeItem.InAppPurchaseV2,
                "subscription" => SubscriptionsPromotedPurchaseGetToOneRelatedIncludeItem.Subscription,
                _ => null,
            };
        }
    }
}