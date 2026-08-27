
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseType2
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
    public static class InAppPurchaseType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseType2 value)
        {
            return value switch
            {
                InAppPurchaseType2.Consumable => "CONSUMABLE",
                InAppPurchaseType2.NonConsumable => "NON_CONSUMABLE",
                InAppPurchaseType2.NonRenewingSubscription => "NON_RENEWING_SUBSCRIPTION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseType2? ToEnum(string value)
        {
            return value switch
            {
                "CONSUMABLE" => InAppPurchaseType2.Consumable,
                "NON_CONSUMABLE" => InAppPurchaseType2.NonConsumable,
                "NON_RENEWING_SUBSCRIPTION" => InAppPurchaseType2.NonRenewingSubscription,
                _ => null,
            };
        }
    }
}