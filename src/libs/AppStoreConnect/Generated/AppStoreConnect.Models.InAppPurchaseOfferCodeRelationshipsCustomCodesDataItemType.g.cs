
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseOfferCodeRelationshipsCustomCodesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseOfferCodeCustomCodes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferCodeRelationshipsCustomCodesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodeRelationshipsCustomCodesDataItemType value)
        {
            return value switch
            {
                InAppPurchaseOfferCodeRelationshipsCustomCodesDataItemType.InAppPurchaseOfferCodeCustomCodes => "inAppPurchaseOfferCodeCustomCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodeRelationshipsCustomCodesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseOfferCodeCustomCodes" => InAppPurchaseOfferCodeRelationshipsCustomCodesDataItemType.InAppPurchaseOfferCodeCustomCodes,
                _ => null,
            };
        }
    }
}