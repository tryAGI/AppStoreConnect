
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasesV2GetInstanceFieldsInAppPurchasePriceSchedule
    {
        /// <summary>
        /// 
        /// </summary>
        AutomaticPrices,
        /// <summary>
        /// 
        /// </summary>
        BaseTerritory,
        /// <summary>
        /// 
        /// </summary>
        ManualPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasesV2GetInstanceFieldsInAppPurchasePriceScheduleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2GetInstanceFieldsInAppPurchasePriceSchedule value)
        {
            return value switch
            {
                InAppPurchasesV2GetInstanceFieldsInAppPurchasePriceSchedule.AutomaticPrices => "automaticPrices",
                InAppPurchasesV2GetInstanceFieldsInAppPurchasePriceSchedule.BaseTerritory => "baseTerritory",
                InAppPurchasesV2GetInstanceFieldsInAppPurchasePriceSchedule.ManualPrices => "manualPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2GetInstanceFieldsInAppPurchasePriceSchedule? ToEnum(string value)
        {
            return value switch
            {
                "automaticPrices" => InAppPurchasesV2GetInstanceFieldsInAppPurchasePriceSchedule.AutomaticPrices,
                "baseTerritory" => InAppPurchasesV2GetInstanceFieldsInAppPurchasePriceSchedule.BaseTerritory,
                "manualPrices" => InAppPurchasesV2GetInstanceFieldsInAppPurchasePriceSchedule.ManualPrices,
                _ => null,
            };
        }
    }
}