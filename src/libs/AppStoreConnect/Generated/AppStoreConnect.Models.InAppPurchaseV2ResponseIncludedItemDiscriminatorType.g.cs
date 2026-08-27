
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseV2ResponseIncludedItemDiscriminatorType
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
    public static class InAppPurchaseV2ResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseV2ResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                InAppPurchaseV2ResponseIncludedItemDiscriminatorType.InAppPurchaseAppStoreReviewScreenshots => "inAppPurchaseAppStoreReviewScreenshots",
                InAppPurchaseV2ResponseIncludedItemDiscriminatorType.InAppPurchaseAvailabilities => "inAppPurchaseAvailabilities",
                InAppPurchaseV2ResponseIncludedItemDiscriminatorType.InAppPurchaseContents => "inAppPurchaseContents",
                InAppPurchaseV2ResponseIncludedItemDiscriminatorType.InAppPurchaseImages => "inAppPurchaseImages",
                InAppPurchaseV2ResponseIncludedItemDiscriminatorType.InAppPurchaseLocalizations => "inAppPurchaseLocalizations",
                InAppPurchaseV2ResponseIncludedItemDiscriminatorType.InAppPurchaseOfferCodes => "inAppPurchaseOfferCodes",
                InAppPurchaseV2ResponseIncludedItemDiscriminatorType.InAppPurchasePricePoints => "inAppPurchasePricePoints",
                InAppPurchaseV2ResponseIncludedItemDiscriminatorType.InAppPurchasePriceSchedules => "inAppPurchasePriceSchedules",
                InAppPurchaseV2ResponseIncludedItemDiscriminatorType.InAppPurchaseVersions => "inAppPurchaseVersions",
                InAppPurchaseV2ResponseIncludedItemDiscriminatorType.PromotedPurchases => "promotedPurchases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseV2ResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseAppStoreReviewScreenshots" => InAppPurchaseV2ResponseIncludedItemDiscriminatorType.InAppPurchaseAppStoreReviewScreenshots,
                "inAppPurchaseAvailabilities" => InAppPurchaseV2ResponseIncludedItemDiscriminatorType.InAppPurchaseAvailabilities,
                "inAppPurchaseContents" => InAppPurchaseV2ResponseIncludedItemDiscriminatorType.InAppPurchaseContents,
                "inAppPurchaseImages" => InAppPurchaseV2ResponseIncludedItemDiscriminatorType.InAppPurchaseImages,
                "inAppPurchaseLocalizations" => InAppPurchaseV2ResponseIncludedItemDiscriminatorType.InAppPurchaseLocalizations,
                "inAppPurchaseOfferCodes" => InAppPurchaseV2ResponseIncludedItemDiscriminatorType.InAppPurchaseOfferCodes,
                "inAppPurchasePricePoints" => InAppPurchaseV2ResponseIncludedItemDiscriminatorType.InAppPurchasePricePoints,
                "inAppPurchasePriceSchedules" => InAppPurchaseV2ResponseIncludedItemDiscriminatorType.InAppPurchasePriceSchedules,
                "inAppPurchaseVersions" => InAppPurchaseV2ResponseIncludedItemDiscriminatorType.InAppPurchaseVersions,
                "promotedPurchases" => InAppPurchaseV2ResponseIncludedItemDiscriminatorType.PromotedPurchases,
                _ => null,
            };
        }
    }
}