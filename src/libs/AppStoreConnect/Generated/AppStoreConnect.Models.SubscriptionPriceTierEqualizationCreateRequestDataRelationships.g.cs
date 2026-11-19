
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionPriceTierEqualizationCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.SubscriptionPriceTierEqualizationCreateRequestDataRelationshipsSubscription Subscription { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("basePricePoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.SubscriptionPriceTierEqualizationCreateRequestDataRelationshipsBasePricePoint BasePricePoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPriceTierEqualizationCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="subscription"></param>
        /// <param name="basePricePoint"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionPriceTierEqualizationCreateRequestDataRelationships(
            global::AppStoreConnect.SubscriptionPriceTierEqualizationCreateRequestDataRelationshipsSubscription subscription,
            global::AppStoreConnect.SubscriptionPriceTierEqualizationCreateRequestDataRelationshipsBasePricePoint basePricePoint)
        {
            this.Subscription = subscription ?? throw new global::System.ArgumentNullException(nameof(subscription));
            this.BasePricePoint = basePricePoint ?? throw new global::System.ArgumentNullException(nameof(basePricePoint));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPriceTierEqualizationCreateRequestDataRelationships" /> class.
        /// </summary>
        public SubscriptionPriceTierEqualizationCreateRequestDataRelationships()
        {
        }

    }
}