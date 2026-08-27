
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasePriceScheduleRelationshipsAutomaticPricesDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchasePrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasePriceScheduleRelationshipsAutomaticPricesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasePriceScheduleRelationshipsAutomaticPricesDataItemType value)
        {
            return value switch
            {
                InAppPurchasePriceScheduleRelationshipsAutomaticPricesDataItemType.InAppPurchasePrices => "inAppPurchasePrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasePriceScheduleRelationshipsAutomaticPricesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchasePrices" => InAppPurchasePriceScheduleRelationshipsAutomaticPricesDataItemType.InAppPurchasePrices,
                _ => null,
            };
        }
    }
}