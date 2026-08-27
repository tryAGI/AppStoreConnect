
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasePriceSchedulesManualPricesGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchasePricePoint,
        /// <summary>
        ///
        /// </summary>
        Territory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasePriceSchedulesManualPricesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasePriceSchedulesManualPricesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                InAppPurchasePriceSchedulesManualPricesGetToManyRelatedIncludeItem.InAppPurchasePricePoint => "inAppPurchasePricePoint",
                InAppPurchasePriceSchedulesManualPricesGetToManyRelatedIncludeItem.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasePriceSchedulesManualPricesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchasePricePoint" => InAppPurchasePriceSchedulesManualPricesGetToManyRelatedIncludeItem.InAppPurchasePricePoint,
                "territory" => InAppPurchasePriceSchedulesManualPricesGetToManyRelatedIncludeItem.Territory,
                _ => null,
            };
        }
    }
}