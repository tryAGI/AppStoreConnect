
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseOfferCodeCustomCodeUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseOfferCodeCustomCodes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferCodeCustomCodeUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodeCustomCodeUpdateRequestDataType value)
        {
            return value switch
            {
                InAppPurchaseOfferCodeCustomCodeUpdateRequestDataType.InAppPurchaseOfferCodeCustomCodes => "inAppPurchaseOfferCodeCustomCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodeCustomCodeUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseOfferCodeCustomCodes" => InAppPurchaseOfferCodeCustomCodeUpdateRequestDataType.InAppPurchaseOfferCodeCustomCodes,
                _ => null,
            };
        }
    }
}