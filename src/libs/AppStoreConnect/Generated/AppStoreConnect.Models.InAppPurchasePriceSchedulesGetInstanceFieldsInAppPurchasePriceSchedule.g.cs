
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasePriceSchedulesGetInstanceFieldsInAppPurchasePriceSchedule
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
    public static class InAppPurchasePriceSchedulesGetInstanceFieldsInAppPurchasePriceScheduleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasePriceSchedulesGetInstanceFieldsInAppPurchasePriceSchedule value)
        {
            return value switch
            {
                InAppPurchasePriceSchedulesGetInstanceFieldsInAppPurchasePriceSchedule.AutomaticPrices => "automaticPrices",
                InAppPurchasePriceSchedulesGetInstanceFieldsInAppPurchasePriceSchedule.BaseTerritory => "baseTerritory",
                InAppPurchasePriceSchedulesGetInstanceFieldsInAppPurchasePriceSchedule.ManualPrices => "manualPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasePriceSchedulesGetInstanceFieldsInAppPurchasePriceSchedule? ToEnum(string value)
        {
            return value switch
            {
                "automaticPrices" => InAppPurchasePriceSchedulesGetInstanceFieldsInAppPurchasePriceSchedule.AutomaticPrices,
                "baseTerritory" => InAppPurchasePriceSchedulesGetInstanceFieldsInAppPurchasePriceSchedule.BaseTerritory,
                "manualPrices" => InAppPurchasePriceSchedulesGetInstanceFieldsInAppPurchasePriceSchedule.ManualPrices,
                _ => null,
            };
        }
    }
}