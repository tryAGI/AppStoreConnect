
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseOfferCodesResponseIncludedItemDiscriminatorType
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
    public static class InAppPurchaseOfferCodesResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodesResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                InAppPurchaseOfferCodesResponseIncludedItemDiscriminatorType.InAppPurchaseOfferCodeCustomCodes => "inAppPurchaseOfferCodeCustomCodes",
                InAppPurchaseOfferCodesResponseIncludedItemDiscriminatorType.InAppPurchaseOfferCodeOneTimeUseCodes => "inAppPurchaseOfferCodeOneTimeUseCodes",
                InAppPurchaseOfferCodesResponseIncludedItemDiscriminatorType.InAppPurchaseOfferPrices => "inAppPurchaseOfferPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodesResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseOfferCodeCustomCodes" => InAppPurchaseOfferCodesResponseIncludedItemDiscriminatorType.InAppPurchaseOfferCodeCustomCodes,
                "inAppPurchaseOfferCodeOneTimeUseCodes" => InAppPurchaseOfferCodesResponseIncludedItemDiscriminatorType.InAppPurchaseOfferCodeOneTimeUseCodes,
                "inAppPurchaseOfferPrices" => InAppPurchaseOfferCodesResponseIncludedItemDiscriminatorType.InAppPurchaseOfferPrices,
                _ => null,
            };
        }
    }
}