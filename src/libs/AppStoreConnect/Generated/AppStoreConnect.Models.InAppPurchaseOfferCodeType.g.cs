
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseOfferCodeType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchaseOfferCodes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferCodeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodeType value)
        {
            return value switch
            {
                InAppPurchaseOfferCodeType.InAppPurchaseOfferCodes => "inAppPurchaseOfferCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodeType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseOfferCodes" => InAppPurchaseOfferCodeType.InAppPurchaseOfferCodes,
                _ => null,
            };
        }
    }
}