
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase
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
    public static class SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase value)
        {
            return value switch
            {
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.Content => "content",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.ContentHosting => "contentHosting",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.FamilySharable => "familySharable",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.IapPriceSchedule => "iapPriceSchedule",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.Images => "images",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.InAppPurchaseAvailability => "inAppPurchaseAvailability",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.InAppPurchaseLocalizations => "inAppPurchaseLocalizations",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.InAppPurchaseType => "inAppPurchaseType",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.Name => "name",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.OfferCodes => "offerCodes",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.PricePoints => "pricePoints",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.ProductId => "productId",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.PromotedPurchase => "promotedPurchase",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.ReviewNote => "reviewNote",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.State => "state",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.AppStoreReviewScreenshot,
                "content" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.Content,
                "contentHosting" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.ContentHosting,
                "familySharable" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.FamilySharable,
                "iapPriceSchedule" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.IapPriceSchedule,
                "images" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.Images,
                "inAppPurchaseAvailability" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.InAppPurchaseAvailability,
                "inAppPurchaseLocalizations" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.InAppPurchaseLocalizations,
                "inAppPurchaseType" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.InAppPurchaseType,
                "name" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.Name,
                "offerCodes" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.OfferCodes,
                "pricePoints" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.PricePoints,
                "productId" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.ProductId,
                "promotedPurchase" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.PromotedPurchase,
                "reviewNote" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.ReviewNote,
                "state" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.State,
                "versions" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsInAppPurchase.Versions,
                _ => null,
            };
        }
    }
}