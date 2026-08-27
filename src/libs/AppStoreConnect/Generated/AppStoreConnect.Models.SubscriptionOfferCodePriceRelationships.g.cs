
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriptionOfferCodePriceRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("territory")]
        public global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsTerritory? Territory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionPricePoint")]
        public global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsSubscriptionPricePoint? SubscriptionPricePoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionOfferCodePriceRelationships" /> class.
        /// </summary>
        /// <param name="territory"></param>
        /// <param name="subscriptionPricePoint"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionOfferCodePriceRelationships(
            global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsTerritory? territory,
            global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsSubscriptionPricePoint? subscriptionPricePoint)
        {
            this.Territory = territory;
            this.SubscriptionPricePoint = subscriptionPricePoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionOfferCodePriceRelationships" /> class.
        /// </summary>
        public SubscriptionOfferCodePriceRelationships()
        {
        }

    }
}