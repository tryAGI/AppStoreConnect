
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionPromotionalOfferPriceInlineCreate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferPriceInlineCreateTypeJsonConverter))]
        public global::AppStoreConnect.SubscriptionPromotionalOfferPriceInlineCreateType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relationships")]
        public global::AppStoreConnect.SubscriptionPromotionalOfferPriceInlineCreateRelationships? Relationships { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPromotionalOfferPriceInlineCreate" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="relationships"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionPromotionalOfferPriceInlineCreate(
            global::AppStoreConnect.SubscriptionPromotionalOfferPriceInlineCreateType type,
            string? id,
            global::AppStoreConnect.SubscriptionPromotionalOfferPriceInlineCreateRelationships? relationships)
        {
            this.Type = type;
            this.Id = id;
            this.Relationships = relationships;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPromotionalOfferPriceInlineCreate" /> class.
        /// </summary>
        public SubscriptionPromotionalOfferPriceInlineCreate()
        {
        }

    }
}