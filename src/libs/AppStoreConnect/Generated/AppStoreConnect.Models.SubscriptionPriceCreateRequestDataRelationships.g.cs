
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionPriceCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.SubscriptionPriceCreateRequestDataRelationshipsSubscription Subscription { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("territory")]
        public global::AppStoreConnect.SubscriptionPriceCreateRequestDataRelationshipsTerritory? Territory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionPricePoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.SubscriptionPriceCreateRequestDataRelationshipsSubscriptionPricePoint SubscriptionPricePoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPriceCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="subscription"></param>
        /// <param name="subscriptionPricePoint"></param>
        /// <param name="territory"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionPriceCreateRequestDataRelationships(
            global::AppStoreConnect.SubscriptionPriceCreateRequestDataRelationshipsSubscription subscription,
            global::AppStoreConnect.SubscriptionPriceCreateRequestDataRelationshipsSubscriptionPricePoint subscriptionPricePoint,
            global::AppStoreConnect.SubscriptionPriceCreateRequestDataRelationshipsTerritory? territory)
        {
            this.Subscription = subscription ?? throw new global::System.ArgumentNullException(nameof(subscription));
            this.Territory = territory;
            this.SubscriptionPricePoint = subscriptionPricePoint ?? throw new global::System.ArgumentNullException(nameof(subscriptionPricePoint));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPriceCreateRequestDataRelationships" /> class.
        /// </summary>
        public SubscriptionPriceCreateRequestDataRelationships()
        {
        }

    }
}