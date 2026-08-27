
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionPromotionalOfferPricesResponseIncludedItemDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferPricesResponseIncludedItemDiscriminatorTypeJsonConverter))]
        public global::AppStoreConnect.SubscriptionPromotionalOfferPricesResponseIncludedItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPromotionalOfferPricesResponseIncludedItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionPromotionalOfferPricesResponseIncludedItemDiscriminator(
            global::AppStoreConnect.SubscriptionPromotionalOfferPricesResponseIncludedItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPromotionalOfferPricesResponseIncludedItemDiscriminator" /> class.
        /// </summary>
        public SubscriptionPromotionalOfferPricesResponseIncludedItemDiscriminator()
        {
        }

    }
}