
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriptionPriceInlineCreateRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        public global::AppStoreConnect.SubscriptionPriceInlineCreateRelationshipsSubscription? Subscription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("territory")]
        public global::AppStoreConnect.SubscriptionPriceInlineCreateRelationshipsTerritory? Territory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionPricePoint")]
        public global::AppStoreConnect.SubscriptionPriceInlineCreateRelationshipsSubscriptionPricePoint? SubscriptionPricePoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPriceInlineCreateRelationships" /> class.
        /// </summary>
        /// <param name="subscription"></param>
        /// <param name="territory"></param>
        /// <param name="subscriptionPricePoint"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionPriceInlineCreateRelationships(
            global::AppStoreConnect.SubscriptionPriceInlineCreateRelationshipsSubscription? subscription,
            global::AppStoreConnect.SubscriptionPriceInlineCreateRelationshipsTerritory? territory,
            global::AppStoreConnect.SubscriptionPriceInlineCreateRelationshipsSubscriptionPricePoint? subscriptionPricePoint)
        {
            this.Subscription = subscription;
            this.Territory = territory;
            this.SubscriptionPricePoint = subscriptionPricePoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPriceInlineCreateRelationships" /> class.
        /// </summary>
        public SubscriptionPriceInlineCreateRelationships()
        {
        }

    }
}