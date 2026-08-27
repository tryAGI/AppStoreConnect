
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePrice
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
    public static class InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePriceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePrice value)
        {
            return value switch
            {
                InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePrice.EndDate => "endDate",
                InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePrice.InAppPurchasePricePoint => "inAppPurchasePricePoint",
                InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePrice.Manual => "manual",
                InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePrice.StartDate => "startDate",
                InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePrice.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePrice? ToEnum(string value)
        {
            return value switch
            {
                "endDate" => InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePrice.EndDate,
                "inAppPurchasePricePoint" => InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePrice.InAppPurchasePricePoint,
                "manual" => InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePrice.Manual,
                "startDate" => InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePrice.StartDate,
                "territory" => InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePrice.Territory,
                _ => null,
            };
        }
    }
}