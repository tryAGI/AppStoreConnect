
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchasePriceSchedule
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
    public static class AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchasePriceScheduleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchasePriceSchedule value)
        {
            return value switch
            {
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchasePriceSchedule.AutomaticPrices => "automaticPrices",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchasePriceSchedule.BaseTerritory => "baseTerritory",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchasePriceSchedule.ManualPrices => "manualPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchasePriceSchedule? ToEnum(string value)
        {
            return value switch
            {
                "automaticPrices" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchasePriceSchedule.AutomaticPrices,
                "baseTerritory" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchasePriceSchedule.BaseTerritory,
                "manualPrices" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchasePriceSchedule.ManualPrices,
                _ => null,
            };
        }
    }
}