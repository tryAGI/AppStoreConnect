
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionUpdateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("introductoryOffers")]
        public global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsIntroductoryOffers? IntroductoryOffers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promotionalOffers")]
        public global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsPromotionalOffers? PromotionalOffers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prices")]
        public global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsPrices? Prices { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retentionMessage")]
        public global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsRetentionMessage? RetentionMessage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retentionMessageOffers")]
        public global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsRetentionMessageOffers? RetentionMessageOffers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUpdateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="introductoryOffers"></param>
        /// <param name="promotionalOffers"></param>
        /// <param name="prices"></param>
        /// <param name="retentionMessage"></param>
        /// <param name="retentionMessageOffers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionUpdateRequestDataRelationships(
            global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsIntroductoryOffers? introductoryOffers,
            global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsPromotionalOffers? promotionalOffers,
            global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsPrices? prices,
            global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsRetentionMessage? retentionMessage,
            global::AppStoreConnect.SubscriptionUpdateRequestDataRelationshipsRetentionMessageOffers? retentionMessageOffers)
        {
            this.IntroductoryOffers = introductoryOffers;
            this.PromotionalOffers = promotionalOffers;
            this.Prices = prices;
            this.RetentionMessage = retentionMessage;
            this.RetentionMessageOffers = retentionMessageOffers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUpdateRequestDataRelationships" /> class.
        /// </summary>
        public SubscriptionUpdateRequestDataRelationships()
        {
        }

    }
}