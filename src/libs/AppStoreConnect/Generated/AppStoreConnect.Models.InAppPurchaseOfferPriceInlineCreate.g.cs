
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InAppPurchaseOfferPriceInlineCreate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.InAppPurchaseOfferPriceInlineCreateTypeJsonConverter))]
        public global::AppStoreConnect.InAppPurchaseOfferPriceInlineCreateType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relationships")]
        public global::AppStoreConnect.InAppPurchaseOfferPriceInlineCreateRelationships? Relationships { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseOfferPriceInlineCreate" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="relationships"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchaseOfferPriceInlineCreate(
            global::AppStoreConnect.InAppPurchaseOfferPriceInlineCreateType type,
            string? id,
            global::AppStoreConnect.InAppPurchaseOfferPriceInlineCreateRelationships? relationships)
        {
            this.Type = type;
            this.Id = id;
            this.Relationships = relationships;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseOfferPriceInlineCreate" /> class.
        /// </summary>
        public InAppPurchaseOfferPriceInlineCreate()
        {
        }

    }
}