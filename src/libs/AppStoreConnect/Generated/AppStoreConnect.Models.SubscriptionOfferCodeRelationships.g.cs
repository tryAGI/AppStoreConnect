
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionOfferCodeRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        public global::AppStoreConnect.SubscriptionOfferCodeRelationshipsSubscription? Subscription { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oneTimeUseCodes")]
        public global::AppStoreConnect.SubscriptionOfferCodeRelationshipsOneTimeUseCodes? OneTimeUseCodes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customCodes")]
        public global::AppStoreConnect.SubscriptionOfferCodeRelationshipsCustomCodes? CustomCodes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prices")]
        public global::AppStoreConnect.SubscriptionOfferCodeRelationshipsPrices? Prices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionOfferCodeRelationships" /> class.
        /// </summary>
        /// <param name="subscription"></param>
        /// <param name="oneTimeUseCodes"></param>
        /// <param name="customCodes"></param>
        /// <param name="prices"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionOfferCodeRelationships(
            global::AppStoreConnect.SubscriptionOfferCodeRelationshipsSubscription? subscription,
            global::AppStoreConnect.SubscriptionOfferCodeRelationshipsOneTimeUseCodes? oneTimeUseCodes,
            global::AppStoreConnect.SubscriptionOfferCodeRelationshipsCustomCodes? customCodes,
            global::AppStoreConnect.SubscriptionOfferCodeRelationshipsPrices? prices)
        {
            this.Subscription = subscription;
            this.OneTimeUseCodes = oneTimeUseCodes;
            this.CustomCodes = customCodes;
            this.Prices = prices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionOfferCodeRelationships" /> class.
        /// </summary>
        public SubscriptionOfferCodeRelationships()
        {
        }

    }
}