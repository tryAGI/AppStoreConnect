
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePrice
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
    public static class InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePriceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePrice value)
        {
            return value switch
            {
                InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePrice.EndDate => "endDate",
                InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePrice.InAppPurchasePricePoint => "inAppPurchasePricePoint",
                InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePrice.Manual => "manual",
                InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePrice.StartDate => "startDate",
                InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePrice.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePrice? ToEnum(string value)
        {
            return value switch
            {
                "endDate" => InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePrice.EndDate,
                "inAppPurchasePricePoint" => InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePrice.InAppPurchasePricePoint,
                "manual" => InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePrice.Manual,
                "startDate" => InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePrice.StartDate,
                "territory" => InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePrice.Territory,
                _ => null,
            };
        }
    }
}