
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasesV2ResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseAppStoreReviewScreenshots,
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseAvailabilities,
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseContents,
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseImages,
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseLocalizations,
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseOfferCodes,
        /// <summary>
        ///
        /// </summary>
        InAppPurchasePricePoints,
        /// <summary>
        ///
        /// </summary>
        InAppPurchasePriceSchedules,
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseVersions,
        /// <summary>
        ///
        /// </summary>
        PromotedPurchases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasesV2ResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2ResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                InAppPurchasesV2ResponseIncludedItemDiscriminatorType.InAppPurchaseAppStoreReviewScreenshots => "inAppPurchaseAppStoreReviewScreenshots",
                InAppPurchasesV2ResponseIncludedItemDiscriminatorType.InAppPurchaseAvailabilities => "inAppPurchaseAvailabilities",
                InAppPurchasesV2ResponseIncludedItemDiscriminatorType.InAppPurchaseContents => "inAppPurchaseContents",
                InAppPurchasesV2ResponseIncludedItemDiscriminatorType.InAppPurchaseImages => "inAppPurchaseImages",
                InAppPurchasesV2ResponseIncludedItemDiscriminatorType.InAppPurchaseLocalizations => "inAppPurchaseLocalizations",
                InAppPurchasesV2ResponseIncludedItemDiscriminatorType.InAppPurchaseOfferCodes => "inAppPurchaseOfferCodes",
                InAppPurchasesV2ResponseIncludedItemDiscriminatorType.InAppPurchasePricePoints => "inAppPurchasePricePoints",
                InAppPurchasesV2ResponseIncludedItemDiscriminatorType.InAppPurchasePriceSchedules => "inAppPurchasePriceSchedules",
                InAppPurchasesV2ResponseIncludedItemDiscriminatorType.InAppPurchaseVersions => "inAppPurchaseVersions",
                InAppPurchasesV2ResponseIncludedItemDiscriminatorType.PromotedPurchases => "promotedPurchases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2ResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseAppStoreReviewScreenshots" => InAppPurchasesV2ResponseIncludedItemDiscriminatorType.InAppPurchaseAppStoreReviewScreenshots,
                "inAppPurchaseAvailabilities" => InAppPurchasesV2ResponseIncludedItemDiscriminatorType.InAppPurchaseAvailabilities,
                "inAppPurchaseContents" => InAppPurchasesV2ResponseIncludedItemDiscriminatorType.InAppPurchaseContents,
                "inAppPurchaseImages" => InAppPurchasesV2ResponseIncludedItemDiscriminatorType.InAppPurchaseImages,
                "inAppPurchaseLocalizations" => InAppPurchasesV2ResponseIncludedItemDiscriminatorType.InAppPurchaseLocalizations,
                "inAppPurchaseOfferCodes" => InAppPurchasesV2ResponseIncludedItemDiscriminatorType.InAppPurchaseOfferCodes,
                "inAppPurchasePricePoints" => InAppPurchasesV2ResponseIncludedItemDiscriminatorType.InAppPurchasePricePoints,
                "inAppPurchasePriceSchedules" => InAppPurchasesV2ResponseIncludedItemDiscriminatorType.InAppPurchasePriceSchedules,
                "inAppPurchaseVersions" => InAppPurchasesV2ResponseIncludedItemDiscriminatorType.InAppPurchaseVersions,
                "promotedPurchases" => InAppPurchasesV2ResponseIncludedItemDiscriminatorType.PromotedPurchases,
                _ => null,
            };
        }
    }
}