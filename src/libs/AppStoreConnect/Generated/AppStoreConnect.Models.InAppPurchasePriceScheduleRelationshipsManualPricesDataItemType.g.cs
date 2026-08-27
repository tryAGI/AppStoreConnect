
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasePriceScheduleRelationshipsManualPricesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchasePrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasePriceScheduleRelationshipsManualPricesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasePriceScheduleRelationshipsManualPricesDataItemType value)
        {
            return value switch
            {
                InAppPurchasePriceScheduleRelationshipsManualPricesDataItemType.InAppPurchasePrices => "inAppPurchasePrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasePriceScheduleRelationshipsManualPricesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchasePrices" => InAppPurchasePriceScheduleRelationshipsManualPricesDataItemType.InAppPurchasePrices,
                _ => null,
            };
        }
    }
}