
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionIntroductoryOfferRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        public global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscription? Subscription { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("territory")]
        public global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsTerritory? Territory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionPricePoint")]
        public global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionPricePoint? SubscriptionPricePoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionIntroductoryOfferRelationships" /> class.
        /// </summary>
        /// <param name="subscription"></param>
        /// <param name="territory"></param>
        /// <param name="subscriptionPricePoint"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionIntroductoryOfferRelationships(
            global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscription? subscription,
            global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsTerritory? territory,
            global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionPricePoint? subscriptionPricePoint)
        {
            this.Subscription = subscription;
            this.Territory = territory;
            this.SubscriptionPricePoint = subscriptionPricePoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionIntroductoryOfferRelationships" /> class.
        /// </summary>
        public SubscriptionIntroductoryOfferRelationships()
        {
        }

    }
}