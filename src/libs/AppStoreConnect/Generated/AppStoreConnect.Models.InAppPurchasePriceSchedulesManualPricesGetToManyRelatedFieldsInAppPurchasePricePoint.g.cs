
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePricePoint
    {
        /// <summary>
        ///
        /// </summary>
        CustomerPrice,
        /// <summary>
        ///
        /// </summary>
        Equalizations,
        /// <summary>
        ///
        /// </summary>
        Proceeds,
        /// <summary>
        ///
        /// </summary>
        Territory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePricePointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePricePoint value)
        {
            return value switch
            {
                InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePricePoint.CustomerPrice => "customerPrice",
                InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePricePoint.Equalizations => "equalizations",
                InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePricePoint.Proceeds => "proceeds",
                InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePricePoint.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePricePoint? ToEnum(string value)
        {
            return value switch
            {
                "customerPrice" => InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePricePoint.CustomerPrice,
                "equalizations" => InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePricePoint.Equalizations,
                "proceeds" => InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePricePoint.Proceeds,
                "territory" => InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePricePoint.Territory,
                _ => null,
            };
        }
    }
}