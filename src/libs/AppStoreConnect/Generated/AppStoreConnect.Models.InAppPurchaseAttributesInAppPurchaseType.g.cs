
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseAttributesInAppPurchaseType
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
    public static class InAppPurchaseAttributesInAppPurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseAttributesInAppPurchaseType value)
        {
            return value switch
            {
                InAppPurchaseAttributesInAppPurchaseType.AutomaticallyRenewableSubscription => "AUTOMATICALLY_RENEWABLE_SUBSCRIPTION",
                InAppPurchaseAttributesInAppPurchaseType.Consumable => "CONSUMABLE",
                InAppPurchaseAttributesInAppPurchaseType.FreeSubscription => "FREE_SUBSCRIPTION",
                InAppPurchaseAttributesInAppPurchaseType.NonConsumable => "NON_CONSUMABLE",
                InAppPurchaseAttributesInAppPurchaseType.NonRenewingSubscription => "NON_RENEWING_SUBSCRIPTION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseAttributesInAppPurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "AUTOMATICALLY_RENEWABLE_SUBSCRIPTION" => InAppPurchaseAttributesInAppPurchaseType.AutomaticallyRenewableSubscription,
                "CONSUMABLE" => InAppPurchaseAttributesInAppPurchaseType.Consumable,
                "FREE_SUBSCRIPTION" => InAppPurchaseAttributesInAppPurchaseType.FreeSubscription,
                "NON_CONSUMABLE" => InAppPurchaseAttributesInAppPurchaseType.NonConsumable,
                "NON_RENEWING_SUBSCRIPTION" => InAppPurchaseAttributesInAppPurchaseType.NonRenewingSubscription,
                _ => null,
            };
        }
    }
}