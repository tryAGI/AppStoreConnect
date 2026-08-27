
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionIntroductoryOfferInlineCreateRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        public global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscription? Subscription { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("territory")]
        public global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateRelationshipsTerritory? Territory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionPricePoint")]
        public global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionPricePoint? SubscriptionPricePoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionIntroductoryOfferInlineCreateRelationships" /> class.
        /// </summary>
        /// <param name="subscription"></param>
        /// <param name="territory"></param>
        /// <param name="subscriptionPricePoint"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionIntroductoryOfferInlineCreateRelationships(
            global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscription? subscription,
            global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateRelationshipsTerritory? territory,
            global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionPricePoint? subscriptionPricePoint)
        {
            this.Subscription = subscription;
            this.Territory = territory;
            this.SubscriptionPricePoint = subscriptionPricePoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionIntroductoryOfferInlineCreateRelationships" /> class.
        /// </summary>
        public SubscriptionIntroductoryOfferInlineCreateRelationships()
        {
        }

    }
}