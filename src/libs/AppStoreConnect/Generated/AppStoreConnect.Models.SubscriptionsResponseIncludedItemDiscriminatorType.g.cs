
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsResponseIncludedItemDiscriminatorType
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
    public static class SubscriptionsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                SubscriptionsResponseIncludedItemDiscriminatorType.PromotedPurchases => "promotedPurchases",
                SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionAppStoreReviewScreenshots => "subscriptionAppStoreReviewScreenshots",
                SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionAvailabilities => "subscriptionAvailabilities",
                SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionGroups => "subscriptionGroups",
                SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionImages => "subscriptionImages",
                SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionIntroductoryOffers => "subscriptionIntroductoryOffers",
                SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionLocalizations => "subscriptionLocalizations",
                SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionOfferCodes => "subscriptionOfferCodes",
                SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionPlanAvailabilities => "subscriptionPlanAvailabilities",
                SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionPrices => "subscriptionPrices",
                SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionPromotionalOffers => "subscriptionPromotionalOffers",
                SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionVersions => "subscriptionVersions",
                SubscriptionsResponseIncludedItemDiscriminatorType.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "promotedPurchases" => SubscriptionsResponseIncludedItemDiscriminatorType.PromotedPurchases,
                "subscriptionAppStoreReviewScreenshots" => SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionAppStoreReviewScreenshots,
                "subscriptionAvailabilities" => SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionAvailabilities,
                "subscriptionGroups" => SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionGroups,
                "subscriptionImages" => SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionImages,
                "subscriptionIntroductoryOffers" => SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionIntroductoryOffers,
                "subscriptionLocalizations" => SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionLocalizations,
                "subscriptionOfferCodes" => SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionOfferCodes,
                "subscriptionPlanAvailabilities" => SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionPlanAvailabilities,
                "subscriptionPrices" => SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionPrices,
                "subscriptionPromotionalOffers" => SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionPromotionalOffers,
                "subscriptionVersions" => SubscriptionsResponseIncludedItemDiscriminatorType.SubscriptionVersions,
                "winBackOffers" => SubscriptionsResponseIncludedItemDiscriminatorType.WinBackOffers,
                _ => null,
            };
        }
    }
}