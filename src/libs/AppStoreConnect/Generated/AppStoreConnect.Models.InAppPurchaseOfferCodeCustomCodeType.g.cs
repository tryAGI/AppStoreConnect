
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseOfferCodeCustomCodeType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseOfferCodeCustomCodes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferCodeCustomCodeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodeCustomCodeType value)
        {
            return value switch
            {
                InAppPurchaseOfferCodeCustomCodeType.InAppPurchaseOfferCodeCustomCodes => "inAppPurchaseOfferCodeCustomCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodeCustomCodeType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseOfferCodeCustomCodes" => InAppPurchaseOfferCodeCustomCodeType.InAppPurchaseOfferCodeCustomCodes,
                _ => null,
            };
        }
    }
}