
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseContentsGetInstanceFieldsInAppPurchase
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreReviewScreenshot,
        /// <summary>
        ///
        /// </summary>
        Content,
        /// <summary>
        ///
        /// </summary>
        ContentHosting,
        /// <summary>
        ///
        /// </summary>
        FamilySharable,
        /// <summary>
        ///
        /// </summary>
        IapPriceSchedule,
        /// <summary>
        ///
        /// </summary>
        Images,
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseAvailability,
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseLocalizations,
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseType,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        OfferCodes,
        /// <summary>
        ///
        /// </summary>
        PricePoints,
        /// <summary>
        ///
        /// </summary>
        ProductId,
        /// <summary>
        ///
        /// </summary>
        PromotedPurchase,
        /// <summary>
        ///
        /// </summary>
        ReviewNote,
        /// <summary>
        ///
        /// </summary>
        State,
        /// <summary>
        ///
        /// </summary>
        Versions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseContentsGetInstanceFieldsInAppPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseContentsGetInstanceFieldsInAppPurchase value)
        {
            return value switch
            {
                InAppPurchaseContentsGetInstanceFieldsInAppPurchase.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                InAppPurchaseContentsGetInstanceFieldsInAppPurchase.Content => "content",
                InAppPurchaseContentsGetInstanceFieldsInAppPurchase.ContentHosting => "contentHosting",
                InAppPurchaseContentsGetInstanceFieldsInAppPurchase.FamilySharable => "familySharable",
                InAppPurchaseContentsGetInstanceFieldsInAppPurchase.IapPriceSchedule => "iapPriceSchedule",
                InAppPurchaseContentsGetInstanceFieldsInAppPurchase.Images => "images",
                InAppPurchaseContentsGetInstanceFieldsInAppPurchase.InAppPurchaseAvailability => "inAppPurchaseAvailability",
                InAppPurchaseContentsGetInstanceFieldsInAppPurchase.InAppPurchaseLocalizations => "inAppPurchaseLocalizations",
                InAppPurchaseContentsGetInstanceFieldsInAppPurchase.InAppPurchaseType => "inAppPurchaseType",
                InAppPurchaseContentsGetInstanceFieldsInAppPurchase.Name => "name",
                InAppPurchaseContentsGetInstanceFieldsInAppPurchase.OfferCodes => "offerCodes",
                InAppPurchaseContentsGetInstanceFieldsInAppPurchase.PricePoints => "pricePoints",
                InAppPurchaseContentsGetInstanceFieldsInAppPurchase.ProductId => "productId",
                InAppPurchaseContentsGetInstanceFieldsInAppPurchase.PromotedPurchase => "promotedPurchase",
                InAppPurchaseContentsGetInstanceFieldsInAppPurchase.ReviewNote => "reviewNote",
                InAppPurchaseContentsGetInstanceFieldsInAppPurchase.State => "state",
                InAppPurchaseContentsGetInstanceFieldsInAppPurchase.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseContentsGetInstanceFieldsInAppPurchase? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => InAppPurchaseContentsGetInstanceFieldsInAppPurchase.AppStoreReviewScreenshot,
                "content" => InAppPurchaseContentsGetInstanceFieldsInAppPurchase.Content,
                "contentHosting" => InAppPurchaseContentsGetInstanceFieldsInAppPurchase.ContentHosting,
                "familySharable" => InAppPurchaseContentsGetInstanceFieldsInAppPurchase.FamilySharable,
                "iapPriceSchedule" => InAppPurchaseContentsGetInstanceFieldsInAppPurchase.IapPriceSchedule,
                "images" => InAppPurchaseContentsGetInstanceFieldsInAppPurchase.Images,
                "inAppPurchaseAvailability" => InAppPurchaseContentsGetInstanceFieldsInAppPurchase.InAppPurchaseAvailability,
                "inAppPurchaseLocalizations" => InAppPurchaseContentsGetInstanceFieldsInAppPurchase.InAppPurchaseLocalizations,
                "inAppPurchaseType" => InAppPurchaseContentsGetInstanceFieldsInAppPurchase.InAppPurchaseType,
                "name" => InAppPurchaseContentsGetInstanceFieldsInAppPurchase.Name,
                "offerCodes" => InAppPurchaseContentsGetInstanceFieldsInAppPurchase.OfferCodes,
                "pricePoints" => InAppPurchaseContentsGetInstanceFieldsInAppPurchase.PricePoints,
                "productId" => InAppPurchaseContentsGetInstanceFieldsInAppPurchase.ProductId,
                "promotedPurchase" => InAppPurchaseContentsGetInstanceFieldsInAppPurchase.PromotedPurchase,
                "reviewNote" => InAppPurchaseContentsGetInstanceFieldsInAppPurchase.ReviewNote,
                "state" => InAppPurchaseContentsGetInstanceFieldsInAppPurchase.State,
                "versions" => InAppPurchaseContentsGetInstanceFieldsInAppPurchase.Versions,
                _ => null,
            };
        }
    }
}