
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseOfferCodeCustomCodeCreateRequestDataRelationshipsOfferCodeDataType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseOfferCodes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferCodeCustomCodeCreateRequestDataRelationshipsOfferCodeDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodeCustomCodeCreateRequestDataRelationshipsOfferCodeDataType value)
        {
            return value switch
            {
                InAppPurchaseOfferCodeCustomCodeCreateRequestDataRelationshipsOfferCodeDataType.InAppPurchaseOfferCodes => "inAppPurchaseOfferCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodeCustomCodeCreateRequestDataRelationshipsOfferCodeDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseOfferCodes" => InAppPurchaseOfferCodeCustomCodeCreateRequestDataRelationshipsOfferCodeDataType.InAppPurchaseOfferCodes,
                _ => null,
            };
        }
    }
}