
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasePriceSchedulesGetInstanceIncludeItem
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
    public static class InAppPurchasePriceSchedulesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasePriceSchedulesGetInstanceIncludeItem value)
        {
            return value switch
            {
                InAppPurchasePriceSchedulesGetInstanceIncludeItem.AutomaticPrices => "automaticPrices",
                InAppPurchasePriceSchedulesGetInstanceIncludeItem.BaseTerritory => "baseTerritory",
                InAppPurchasePriceSchedulesGetInstanceIncludeItem.ManualPrices => "manualPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasePriceSchedulesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "automaticPrices" => InAppPurchasePriceSchedulesGetInstanceIncludeItem.AutomaticPrices,
                "baseTerritory" => InAppPurchasePriceSchedulesGetInstanceIncludeItem.BaseTerritory,
                "manualPrices" => InAppPurchasePriceSchedulesGetInstanceIncludeItem.ManualPrices,
                _ => null,
            };
        }
    }
}