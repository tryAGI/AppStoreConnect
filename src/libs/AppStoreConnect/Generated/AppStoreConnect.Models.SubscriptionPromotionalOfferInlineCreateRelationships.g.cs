
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionPromotionalOfferInlineCreateRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        public global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateRelationshipsSubscription? Subscription { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prices")]
        public global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateRelationshipsPrices? Prices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPromotionalOfferInlineCreateRelationships" /> class.
        /// </summary>
        /// <param name="subscription"></param>
        /// <param name="prices"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionPromotionalOfferInlineCreateRelationships(
            global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateRelationshipsSubscription? subscription,
            global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateRelationshipsPrices? prices)
        {
            this.Subscription = subscription;
            this.Prices = prices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPromotionalOfferInlineCreateRelationships" /> class.
        /// </summary>
        public SubscriptionPromotionalOfferInlineCreateRelationships()
        {
        }

    }
}