
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RetentionOfferCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.RetentionOfferCreateRequestDataRelationshipsSubscription Subscription { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.RetentionOfferCreateRequestDataRelationshipsPrices Prices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionOfferCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="subscription"></param>
        /// <param name="prices"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetentionOfferCreateRequestDataRelationships(
            global::AppStoreConnect.RetentionOfferCreateRequestDataRelationshipsSubscription subscription,
            global::AppStoreConnect.RetentionOfferCreateRequestDataRelationshipsPrices prices)
        {
            this.Subscription = subscription ?? throw new global::System.ArgumentNullException(nameof(subscription));
            this.Prices = prices ?? throw new global::System.ArgumentNullException(nameof(prices));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionOfferCreateRequestDataRelationships" /> class.
        /// </summary>
        public RetentionOfferCreateRequestDataRelationships()
        {
        }

    }
}