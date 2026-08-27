
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionPromotionalOfferInlineCreate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferInlineCreateTypeJsonConverter))]
        public global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateAttributes Attributes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relationships")]
        public global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateRelationships? Relationships { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPromotionalOfferInlineCreate" /> class.
        /// </summary>
        /// <param name="attributes"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="relationships"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionPromotionalOfferInlineCreate(
            global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateAttributes attributes,
            global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateType type,
            string? id,
            global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreateRelationships? relationships)
        {
            this.Type = type;
            this.Id = id;
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
            this.Relationships = relationships;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPromotionalOfferInlineCreate" /> class.
        /// </summary>
        public SubscriptionPromotionalOfferInlineCreate()
        {
        }

    }
}