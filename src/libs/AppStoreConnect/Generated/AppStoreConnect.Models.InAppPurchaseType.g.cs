
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseType
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
    public static class InAppPurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseType value)
        {
            return value switch
            {
                InAppPurchaseType.Consumable => "CONSUMABLE",
                InAppPurchaseType.NonConsumable => "NON_CONSUMABLE",
                InAppPurchaseType.NonRenewingSubscription => "NON_RENEWING_SUBSCRIPTION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "CONSUMABLE" => InAppPurchaseType.Consumable,
                "NON_CONSUMABLE" => InAppPurchaseType.NonConsumable,
                "NON_RENEWING_SUBSCRIPTION" => InAppPurchaseType.NonRenewingSubscription,
                _ => null,
            };
        }
    }
}