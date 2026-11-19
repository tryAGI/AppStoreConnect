
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProposedSubscriptionPriceTier
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minQuantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MinQuantity { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionPricePointId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscriptionPricePointId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProposedSubscriptionPriceTier" /> class.
        /// </summary>
        /// <param name="minQuantity"></param>
        /// <param name="subscriptionPricePointId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProposedSubscriptionPriceTier(
            int minQuantity,
            string subscriptionPricePointId)
        {
            this.MinQuantity = minQuantity;
            this.SubscriptionPricePointId = subscriptionPricePointId ?? throw new global::System.ArgumentNullException(nameof(subscriptionPricePointId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProposedSubscriptionPriceTier" /> class.
        /// </summary>
        public ProposedSubscriptionPriceTier()
        {
        }

    }
}