
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionPriceTierInlineCreateRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionPricePoint")]
        public global::AppStoreConnect.SubscriptionPriceTierInlineCreateRelationshipsSubscriptionPricePoint? SubscriptionPricePoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPriceTierInlineCreateRelationships" /> class.
        /// </summary>
        /// <param name="subscriptionPricePoint"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionPriceTierInlineCreateRelationships(
            global::AppStoreConnect.SubscriptionPriceTierInlineCreateRelationshipsSubscriptionPricePoint? subscriptionPricePoint)
        {
            this.SubscriptionPricePoint = subscriptionPricePoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPriceTierInlineCreateRelationships" /> class.
        /// </summary>
        public SubscriptionPriceTierInlineCreateRelationships()
        {
        }

    }
}