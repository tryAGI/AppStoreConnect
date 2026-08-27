
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasePriceScheduleManualPricesLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchasePrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasePriceScheduleManualPricesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasePriceScheduleManualPricesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                InAppPurchasePriceScheduleManualPricesLinkagesResponseDataItemType.InAppPurchasePrices => "inAppPurchasePrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasePriceScheduleManualPricesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchasePrices" => InAppPurchasePriceScheduleManualPricesLinkagesResponseDataItemType.InAppPurchasePrices,
                _ => null,
            };
        }
    }
}