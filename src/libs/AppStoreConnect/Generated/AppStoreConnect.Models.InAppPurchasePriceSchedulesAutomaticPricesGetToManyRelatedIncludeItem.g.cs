
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedIncludeItem
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
    public static class InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedIncludeItem.InAppPurchasePricePoint => "inAppPurchasePricePoint",
                InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedIncludeItem.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchasePricePoint" => InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedIncludeItem.InAppPurchasePricePoint,
                "territory" => InAppPurchasePriceSchedulesAutomaticPricesGetToManyRelatedIncludeItem.Territory,
                _ => null,
            };
        }
    }
}