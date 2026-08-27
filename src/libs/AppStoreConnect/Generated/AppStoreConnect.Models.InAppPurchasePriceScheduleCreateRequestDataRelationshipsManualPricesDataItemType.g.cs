
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasePriceScheduleCreateRequestDataRelationshipsManualPricesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchasePrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasePriceScheduleCreateRequestDataRelationshipsManualPricesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasePriceScheduleCreateRequestDataRelationshipsManualPricesDataItemType value)
        {
            return value switch
            {
                InAppPurchasePriceScheduleCreateRequestDataRelationshipsManualPricesDataItemType.InAppPurchasePrices => "inAppPurchasePrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasePriceScheduleCreateRequestDataRelationshipsManualPricesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchasePrices" => InAppPurchasePriceScheduleCreateRequestDataRelationshipsManualPricesDataItemType.InAppPurchasePrices,
                _ => null,
            };
        }
    }
}