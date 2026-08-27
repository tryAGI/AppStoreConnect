
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseOfferCodeRelationshipsOneTimeUseCodesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseOfferCodeOneTimeUseCodes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferCodeRelationshipsOneTimeUseCodesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodeRelationshipsOneTimeUseCodesDataItemType value)
        {
            return value switch
            {
                InAppPurchaseOfferCodeRelationshipsOneTimeUseCodesDataItemType.InAppPurchaseOfferCodeOneTimeUseCodes => "inAppPurchaseOfferCodeOneTimeUseCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodeRelationshipsOneTimeUseCodesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseOfferCodeOneTimeUseCodes" => InAppPurchaseOfferCodeRelationshipsOneTimeUseCodesDataItemType.InAppPurchaseOfferCodeOneTimeUseCodes,
                _ => null,
            };
        }
    }
}