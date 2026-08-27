
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseOfferCodesGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        CustomCodes,
        /// <summary>
        ///
        /// </summary>
        OneTimeUseCodes,
        /// <summary>
        ///
        /// </summary>
        Prices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferCodesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodesGetInstanceIncludeItem value)
        {
            return value switch
            {
                InAppPurchaseOfferCodesGetInstanceIncludeItem.CustomCodes => "customCodes",
                InAppPurchaseOfferCodesGetInstanceIncludeItem.OneTimeUseCodes => "oneTimeUseCodes",
                InAppPurchaseOfferCodesGetInstanceIncludeItem.Prices => "prices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "customCodes" => InAppPurchaseOfferCodesGetInstanceIncludeItem.CustomCodes,
                "oneTimeUseCodes" => InAppPurchaseOfferCodesGetInstanceIncludeItem.OneTimeUseCodes,
                "prices" => InAppPurchaseOfferCodesGetInstanceIncludeItem.Prices,
                _ => null,
            };
        }
    }
}