
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionPriceTierInlineCreate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SubscriptionPriceTierInlineCreateTypeJsonConverter))]
        public global::AppStoreConnect.SubscriptionPriceTierInlineCreateType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::AppStoreConnect.SubscriptionPriceTierInlineCreateAttributes? Attributes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relationships")]
        public global::AppStoreConnect.SubscriptionPriceTierInlineCreateRelationships? Relationships { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPriceTierInlineCreate" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="attributes"></param>
        /// <param name="relationships"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionPriceTierInlineCreate(
            global::AppStoreConnect.SubscriptionPriceTierInlineCreateType type,
            string? id,
            global::AppStoreConnect.SubscriptionPriceTierInlineCreateAttributes? attributes,
            global::AppStoreConnect.SubscriptionPriceTierInlineCreateRelationships? relationships)
        {
            this.Type = type;
            this.Id = id;
            this.Attributes = attributes;
            this.Relationships = relationships;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPriceTierInlineCreate" /> class.
        /// </summary>
        public SubscriptionPriceTierInlineCreate()
        {
        }

    }
}