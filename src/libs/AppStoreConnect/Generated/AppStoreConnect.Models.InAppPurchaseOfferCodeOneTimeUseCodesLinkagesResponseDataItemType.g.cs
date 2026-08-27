
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseOfferCodeOneTimeUseCodesLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchaseOfferCodeOneTimeUseCodes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferCodeOneTimeUseCodesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodeOneTimeUseCodesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                InAppPurchaseOfferCodeOneTimeUseCodesLinkagesResponseDataItemType.InAppPurchaseOfferCodeOneTimeUseCodes => "inAppPurchaseOfferCodeOneTimeUseCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodeOneTimeUseCodesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseOfferCodeOneTimeUseCodes" => InAppPurchaseOfferCodeOneTimeUseCodesLinkagesResponseDataItemType.InAppPurchaseOfferCodeOneTimeUseCodes,
                _ => null,
            };
        }
    }
}