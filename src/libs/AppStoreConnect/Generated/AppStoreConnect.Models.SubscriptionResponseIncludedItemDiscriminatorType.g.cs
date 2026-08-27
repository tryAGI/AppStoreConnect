
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        PromotedPurchases,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionAppStoreReviewScreenshots,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionAvailabilities,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionGroups,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionImages,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionIntroductoryOffers,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionLocalizations,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionOfferCodes,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionPlanAvailabilities,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionPrices,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionPromotionalOffers,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionVersions,
        /// <summary>
        /// 
        /// </summary>
        WinBackOffers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                SubscriptionResponseIncludedItemDiscriminatorType.PromotedPurchases => "promotedPurchases",
                SubscriptionResponseIncludedItemDiscriminatorType.SubscriptionAppStoreReviewScreenshots => "subscriptionAppStoreReviewScreenshots",
                SubscriptionResponseIncludedItemDiscriminatorType.SubscriptionAvailabilities => "subscriptionAvailabilities",
                SubscriptionResponseIncludedItemDiscriminatorType.SubscriptionGroups => "subscriptionGroups",
                SubscriptionResponseIncludedItemDiscriminatorType.SubscriptionImages => "subscriptionImages",
                SubscriptionResponseIncludedItemDiscriminatorType.SubscriptionIntroductoryOffers => "subscriptionIntroductoryOffers",
                SubscriptionResponseIncludedItemDiscriminatorType.SubscriptionLocalizations => "subscriptionLocalizations",
                SubscriptionResponseIncludedItemDiscriminatorType.SubscriptionOfferCodes => "subscriptionOfferCodes",
                SubscriptionResponseIncludedItemDiscriminatorType.SubscriptionPlanAvailabilities => "subscriptionPlanAvailabilities",
                SubscriptionResponseIncludedItemDiscriminatorType.SubscriptionPrices => "subscriptionPrices",
                SubscriptionResponseIncludedItemDiscriminatorType.SubscriptionPromotionalOffers => "subscriptionPromotionalOffers",
                SubscriptionResponseIncludedItemDiscriminatorType.SubscriptionVersions => "subscriptionVersions",
                SubscriptionResponseIncludedItemDiscriminatorType.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "promotedPurchases" => SubscriptionResponseIncludedItemDiscriminatorType.PromotedPurchases,
                "subscriptionAppStoreReviewScreenshots" => SubscriptionResponseIncludedItemDiscriminatorType.SubscriptionAppStoreReviewScreenshots,
                "subscriptionAvailabilities" => SubscriptionResponseIncludedItemDiscriminatorType.SubscriptionAvailabilities,
                "subscriptionGroups" => SubscriptionResponseIncludedItemDiscriminatorType.SubscriptionGroups,
                "subscriptionImages" => SubscriptionResponseIncludedItemDiscriminatorType.SubscriptionImages,
                "subscriptionIntroductoryOffers" => SubscriptionResponseIncludedItemDiscriminatorType.SubscriptionIntroductoryOffers,
                "subscriptionLocalizations" => SubscriptionResponseIncludedItemDiscriminatorType.SubscriptionLocalizations,
                "subscriptionOfferCodes" => SubscriptionResponseIncludedItemDiscriminatorType.SubscriptionOfferCodes,
                "subscriptionPlanAvailabilities" => SubscriptionResponseIncludedItemDiscriminatorType.SubscriptionPlanAvailabilities,
                "subscriptionPrices" => SubscriptionResponseIncludedItemDiscriminatorType.SubscriptionPrices,
                "subscriptionPromotionalOffers" => SubscriptionResponseIncludedItemDiscriminatorType.SubscriptionPromotionalOffers,
                "subscriptionVersions" => SubscriptionResponseIncludedItemDiscriminatorType.SubscriptionVersions,
                "winBackOffers" => SubscriptionResponseIncludedItemDiscriminatorType.WinBackOffers,
                _ => null,
            };
        }
    }
}