
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseOfferCodeResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseOfferCodeCustomCodes,
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseOfferCodeOneTimeUseCodes,
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseOfferPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferCodeResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodeResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                InAppPurchaseOfferCodeResponseIncludedItemDiscriminatorType.InAppPurchaseOfferCodeCustomCodes => "inAppPurchaseOfferCodeCustomCodes",
                InAppPurchaseOfferCodeResponseIncludedItemDiscriminatorType.InAppPurchaseOfferCodeOneTimeUseCodes => "inAppPurchaseOfferCodeOneTimeUseCodes",
                InAppPurchaseOfferCodeResponseIncludedItemDiscriminatorType.InAppPurchaseOfferPrices => "inAppPurchaseOfferPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodeResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseOfferCodeCustomCodes" => InAppPurchaseOfferCodeResponseIncludedItemDiscriminatorType.InAppPurchaseOfferCodeCustomCodes,
                "inAppPurchaseOfferCodeOneTimeUseCodes" => InAppPurchaseOfferCodeResponseIncludedItemDiscriminatorType.InAppPurchaseOfferCodeOneTimeUseCodes,
                "inAppPurchaseOfferPrices" => InAppPurchaseOfferCodeResponseIncludedItemDiscriminatorType.InAppPurchaseOfferPrices,
                _ => null,
            };
        }
    }
}