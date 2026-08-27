
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseOfferCodeCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseOfferCodes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferCodeCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodeCreateRequestDataType value)
        {
            return value switch
            {
                InAppPurchaseOfferCodeCreateRequestDataType.InAppPurchaseOfferCodes => "inAppPurchaseOfferCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodeCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseOfferCodes" => InAppPurchaseOfferCodeCreateRequestDataType.InAppPurchaseOfferCodes,
                _ => null,
            };
        }
    }
}