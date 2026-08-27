
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasesV2OfferCodesGetToManyRelatedIncludeItem
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
    public static class InAppPurchasesV2OfferCodesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2OfferCodesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                InAppPurchasesV2OfferCodesGetToManyRelatedIncludeItem.CustomCodes => "customCodes",
                InAppPurchasesV2OfferCodesGetToManyRelatedIncludeItem.OneTimeUseCodes => "oneTimeUseCodes",
                InAppPurchasesV2OfferCodesGetToManyRelatedIncludeItem.Prices => "prices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2OfferCodesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "customCodes" => InAppPurchasesV2OfferCodesGetToManyRelatedIncludeItem.CustomCodes,
                "oneTimeUseCodes" => InAppPurchasesV2OfferCodesGetToManyRelatedIncludeItem.OneTimeUseCodes,
                "prices" => InAppPurchasesV2OfferCodesGetToManyRelatedIncludeItem.Prices,
                _ => null,
            };
        }
    }
}