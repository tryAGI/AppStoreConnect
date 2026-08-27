
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseV2IapPriceScheduleLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchasePriceSchedules,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseV2IapPriceScheduleLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseV2IapPriceScheduleLinkageResponseDataType value)
        {
            return value switch
            {
                InAppPurchaseV2IapPriceScheduleLinkageResponseDataType.InAppPurchasePriceSchedules => "inAppPurchasePriceSchedules",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseV2IapPriceScheduleLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchasePriceSchedules" => InAppPurchaseV2IapPriceScheduleLinkageResponseDataType.InAppPurchasePriceSchedules,
                _ => null,
            };
        }
    }
}