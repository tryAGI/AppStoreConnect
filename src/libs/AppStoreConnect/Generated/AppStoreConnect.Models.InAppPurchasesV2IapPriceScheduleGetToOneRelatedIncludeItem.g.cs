
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasesV2IapPriceScheduleGetToOneRelatedIncludeItem
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
    public static class InAppPurchasesV2IapPriceScheduleGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2IapPriceScheduleGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                InAppPurchasesV2IapPriceScheduleGetToOneRelatedIncludeItem.AutomaticPrices => "automaticPrices",
                InAppPurchasesV2IapPriceScheduleGetToOneRelatedIncludeItem.BaseTerritory => "baseTerritory",
                InAppPurchasesV2IapPriceScheduleGetToOneRelatedIncludeItem.ManualPrices => "manualPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2IapPriceScheduleGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "automaticPrices" => InAppPurchasesV2IapPriceScheduleGetToOneRelatedIncludeItem.AutomaticPrices,
                "baseTerritory" => InAppPurchasesV2IapPriceScheduleGetToOneRelatedIncludeItem.BaseTerritory,
                "manualPrices" => InAppPurchasesV2IapPriceScheduleGetToOneRelatedIncludeItem.ManualPrices,
                _ => null,
            };
        }
    }
}