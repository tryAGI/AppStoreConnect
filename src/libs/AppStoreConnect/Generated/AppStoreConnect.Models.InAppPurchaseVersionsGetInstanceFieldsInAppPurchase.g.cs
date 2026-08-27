
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseVersionsGetInstanceFieldsInAppPurchase
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
    public static class InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseVersionsGetInstanceFieldsInAppPurchase value)
        {
            return value switch
            {
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.Content => "content",
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.ContentHosting => "contentHosting",
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.FamilySharable => "familySharable",
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.IapPriceSchedule => "iapPriceSchedule",
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.Images => "images",
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.InAppPurchaseAvailability => "inAppPurchaseAvailability",
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.InAppPurchaseLocalizations => "inAppPurchaseLocalizations",
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.InAppPurchaseType => "inAppPurchaseType",
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.Name => "name",
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.OfferCodes => "offerCodes",
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.PricePoints => "pricePoints",
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.ProductId => "productId",
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.PromotedPurchase => "promotedPurchase",
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.ReviewNote => "reviewNote",
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.State => "state",
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseVersionsGetInstanceFieldsInAppPurchase? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.AppStoreReviewScreenshot,
                "content" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.Content,
                "contentHosting" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.ContentHosting,
                "familySharable" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.FamilySharable,
                "iapPriceSchedule" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.IapPriceSchedule,
                "images" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.Images,
                "inAppPurchaseAvailability" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.InAppPurchaseAvailability,
                "inAppPurchaseLocalizations" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.InAppPurchaseLocalizations,
                "inAppPurchaseType" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.InAppPurchaseType,
                "name" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.Name,
                "offerCodes" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.OfferCodes,
                "pricePoints" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.PricePoints,
                "productId" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.ProductId,
                "promotedPurchase" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.PromotedPurchase,
                "reviewNote" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.ReviewNote,
                "state" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.State,
                "versions" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchase.Versions,
                _ => null,
            };
        }
    }
}