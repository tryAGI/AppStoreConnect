
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasesV2IapPriceScheduleGetToOneRelatedFieldsInAppPurchasePrice
    {
        /// <summary>
        ///
        /// </summary>
        EndDate,
        /// <summary>
        ///
        /// </summary>
        InAppPurchasePricePoint,
        /// <summary>
        ///
        /// </summary>
        Manual,
        /// <summary>
        ///
        /// </summary>
        StartDate,
        /// <summary>
        ///
        /// </summary>
        Territory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasesV2IapPriceScheduleGetToOneRelatedFieldsInAppPurchasePriceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2IapPriceScheduleGetToOneRelatedFieldsInAppPurchasePrice value)
        {
            return value switch
            {
                InAppPurchasesV2IapPriceScheduleGetToOneRelatedFieldsInAppPurchasePrice.EndDate => "endDate",
                InAppPurchasesV2IapPriceScheduleGetToOneRelatedFieldsInAppPurchasePrice.InAppPurchasePricePoint => "inAppPurchasePricePoint",
                InAppPurchasesV2IapPriceScheduleGetToOneRelatedFieldsInAppPurchasePrice.Manual => "manual",
                InAppPurchasesV2IapPriceScheduleGetToOneRelatedFieldsInAppPurchasePrice.StartDate => "startDate",
                InAppPurchasesV2IapPriceScheduleGetToOneRelatedFieldsInAppPurchasePrice.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2IapPriceScheduleGetToOneRelatedFieldsInAppPurchasePrice? ToEnum(string value)
        {
            return value switch
            {
                "endDate" => InAppPurchasesV2IapPriceScheduleGetToOneRelatedFieldsInAppPurchasePrice.EndDate,
                "inAppPurchasePricePoint" => InAppPurchasesV2IapPriceScheduleGetToOneRelatedFieldsInAppPurchasePrice.InAppPurchasePricePoint,
                "manual" => InAppPurchasesV2IapPriceScheduleGetToOneRelatedFieldsInAppPurchasePrice.Manual,
                "startDate" => InAppPurchasesV2IapPriceScheduleGetToOneRelatedFieldsInAppPurchasePrice.StartDate,
                "territory" => InAppPurchasesV2IapPriceScheduleGetToOneRelatedFieldsInAppPurchasePrice.Territory,
                _ => null,
            };
        }
    }
}