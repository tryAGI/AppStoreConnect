
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionLocalizations")]
        public global::AppStoreConnect.SubscriptionRelationshipsSubscriptionLocalizations? SubscriptionLocalizations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreReviewScreenshot")]
        public global::AppStoreConnect.SubscriptionRelationshipsAppStoreReviewScreenshot? AppStoreReviewScreenshot { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        public global::AppStoreConnect.SubscriptionRelationshipsGroup? Group { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("introductoryOffers")]
        public global::AppStoreConnect.SubscriptionRelationshipsIntroductoryOffers? IntroductoryOffers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promotionalOffers")]
        public global::AppStoreConnect.SubscriptionRelationshipsPromotionalOffers? PromotionalOffers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offerCodes")]
        public global::AppStoreConnect.SubscriptionRelationshipsOfferCodes? OfferCodes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prices")]
        public global::AppStoreConnect.SubscriptionRelationshipsPrices? Prices { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricePoints")]
        public global::AppStoreConnect.SubscriptionRelationshipsPricePoints? PricePoints { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promotedPurchase")]
        public global::AppStoreConnect.SubscriptionRelationshipsPromotedPurchase? PromotedPurchase { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionAvailability")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::AppStoreConnect.SubscriptionRelationshipsSubscriptionAvailability? SubscriptionAvailability { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("winBackOffers")]
        public global::AppStoreConnect.SubscriptionRelationshipsWinBackOffers? WinBackOffers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::AppStoreConnect.SubscriptionRelationshipsImages? Images { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planAvailabilities")]
        public global::AppStoreConnect.SubscriptionRelationshipsPlanAvailabilities? PlanAvailabilities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        public global::AppStoreConnect.SubscriptionRelationshipsVersions? Versions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionRelationships" /> class.
        /// </summary>
        /// <param name="subscriptionLocalizations"></param>
        /// <param name="appStoreReviewScreenshot"></param>
        /// <param name="group"></param>
        /// <param name="introductoryOffers"></param>
        /// <param name="promotionalOffers"></param>
        /// <param name="offerCodes"></param>
        /// <param name="prices"></param>
        /// <param name="pricePoints"></param>
        /// <param name="promotedPurchase"></param>
        /// <param name="winBackOffers"></param>
        /// <param name="images"></param>
        /// <param name="planAvailabilities"></param>
        /// <param name="versions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionRelationships(
            global::AppStoreConnect.SubscriptionRelationshipsSubscriptionLocalizations? subscriptionLocalizations,
            global::AppStoreConnect.SubscriptionRelationshipsAppStoreReviewScreenshot? appStoreReviewScreenshot,
            global::AppStoreConnect.SubscriptionRelationshipsGroup? group,
            global::AppStoreConnect.SubscriptionRelationshipsIntroductoryOffers? introductoryOffers,
            global::AppStoreConnect.SubscriptionRelationshipsPromotionalOffers? promotionalOffers,
            global::AppStoreConnect.SubscriptionRelationshipsOfferCodes? offerCodes,
            global::AppStoreConnect.SubscriptionRelationshipsPrices? prices,
            global::AppStoreConnect.SubscriptionRelationshipsPricePoints? pricePoints,
            global::AppStoreConnect.SubscriptionRelationshipsPromotedPurchase? promotedPurchase,
            global::AppStoreConnect.SubscriptionRelationshipsWinBackOffers? winBackOffers,
            global::AppStoreConnect.SubscriptionRelationshipsImages? images,
            global::AppStoreConnect.SubscriptionRelationshipsPlanAvailabilities? planAvailabilities,
            global::AppStoreConnect.SubscriptionRelationshipsVersions? versions)
        {
            this.SubscriptionLocalizations = subscriptionLocalizations;
            this.AppStoreReviewScreenshot = appStoreReviewScreenshot;
            this.Group = group;
            this.IntroductoryOffers = introductoryOffers;
            this.PromotionalOffers = promotionalOffers;
            this.OfferCodes = offerCodes;
            this.Prices = prices;
            this.PricePoints = pricePoints;
            this.PromotedPurchase = promotedPurchase;
            this.WinBackOffers = winBackOffers;
            this.Images = images;
            this.PlanAvailabilities = planAvailabilities;
            this.Versions = versions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionRelationships" /> class.
        /// </summary>
        public SubscriptionRelationships()
        {
        }

    }
}