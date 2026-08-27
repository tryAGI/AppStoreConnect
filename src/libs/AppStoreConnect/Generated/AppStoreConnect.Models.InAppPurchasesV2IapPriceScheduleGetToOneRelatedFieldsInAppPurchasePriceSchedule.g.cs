
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasesV2IapPriceScheduleGetToOneRelatedFieldsInAppPurchasePriceSchedule
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
    public static class InAppPurchasesV2IapPriceScheduleGetToOneRelatedFieldsInAppPurchasePriceScheduleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2IapPriceScheduleGetToOneRelatedFieldsInAppPurchasePriceSchedule value)
        {
            return value switch
            {
                InAppPurchasesV2IapPriceScheduleGetToOneRelatedFieldsInAppPurchasePriceSchedule.AutomaticPrices => "automaticPrices",
                InAppPurchasesV2IapPriceScheduleGetToOneRelatedFieldsInAppPurchasePriceSchedule.BaseTerritory => "baseTerritory",
                InAppPurchasesV2IapPriceScheduleGetToOneRelatedFieldsInAppPurchasePriceSchedule.ManualPrices => "manualPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2IapPriceScheduleGetToOneRelatedFieldsInAppPurchasePriceSchedule? ToEnum(string value)
        {
            return value switch
            {
                "automaticPrices" => InAppPurchasesV2IapPriceScheduleGetToOneRelatedFieldsInAppPurchasePriceSchedule.AutomaticPrices,
                "baseTerritory" => InAppPurchasesV2IapPriceScheduleGetToOneRelatedFieldsInAppPurchasePriceSchedule.BaseTerritory,
                "manualPrices" => InAppPurchasesV2IapPriceScheduleGetToOneRelatedFieldsInAppPurchasePriceSchedule.ManualPrices,
                _ => null,
            };
        }
    }
}