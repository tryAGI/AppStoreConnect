
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePricePoint
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
    public static class InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePricePointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePricePoint value)
        {
            return value switch
            {
                InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePricePoint.CustomerPrice => "customerPrice",
                InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePricePoint.Equalizations => "equalizations",
                InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePricePoint.Proceeds => "proceeds",
                InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePricePoint.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePricePoint? ToEnum(string value)
        {
            return value switch
            {
                "customerPrice" => InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePricePoint.CustomerPrice,
                "equalizations" => InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePricePoint.Equalizations,
                "proceeds" => InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePricePoint.Proceeds,
                "territory" => InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedFieldsInAppPurchasePricePoint.Territory,
                _ => null,
            };
        }
    }
}