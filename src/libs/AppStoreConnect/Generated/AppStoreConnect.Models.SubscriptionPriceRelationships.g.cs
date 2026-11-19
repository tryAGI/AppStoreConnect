
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionPriceRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("territory")]
        public global::AppStoreConnect.SubscriptionPriceRelationshipsTerritory? Territory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionPricePoint")]
        public global::AppStoreConnect.SubscriptionPriceRelationshipsSubscriptionPricePoint? SubscriptionPricePoint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additionalPriceTiers")]
        public global::AppStoreConnect.SubscriptionPriceRelationshipsAdditionalPriceTiers? AdditionalPriceTiers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPriceRelationships" /> class.
        /// </summary>
        /// <param name="territory"></param>
        /// <param name="subscriptionPricePoint"></param>
        /// <param name="additionalPriceTiers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionPriceRelationships(
            global::AppStoreConnect.SubscriptionPriceRelationshipsTerritory? territory,
            global::AppStoreConnect.SubscriptionPriceRelationshipsSubscriptionPricePoint? subscriptionPricePoint,
            global::AppStoreConnect.SubscriptionPriceRelationshipsAdditionalPriceTiers? additionalPriceTiers)
        {
            this.Territory = territory;
            this.SubscriptionPricePoint = subscriptionPricePoint;
            this.AdditionalPriceTiers = additionalPriceTiers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPriceRelationships" /> class.
        /// </summary>
        public SubscriptionPriceRelationships()
        {
        }

    }
}