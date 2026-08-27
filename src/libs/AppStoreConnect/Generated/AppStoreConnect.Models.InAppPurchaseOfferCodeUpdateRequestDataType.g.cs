
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseOfferCodeUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchaseOfferCodes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferCodeUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodeUpdateRequestDataType value)
        {
            return value switch
            {
                InAppPurchaseOfferCodeUpdateRequestDataType.InAppPurchaseOfferCodes => "inAppPurchaseOfferCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodeUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseOfferCodes" => InAppPurchaseOfferCodeUpdateRequestDataType.InAppPurchaseOfferCodes,
                _ => null,
            };
        }
    }
}