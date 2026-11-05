
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RetentionOfferPriceInlineCreate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.RetentionOfferPriceInlineCreateTypeJsonConverter))]
        public global::AppStoreConnect.RetentionOfferPriceInlineCreateType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionOfferPriceInlineCreate" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetentionOfferPriceInlineCreate(
            global::AppStoreConnect.RetentionOfferPriceInlineCreateType type,
            string? id)
        {
            this.Type = type;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionOfferPriceInlineCreate" /> class.
        /// </summary>
        public RetentionOfferPriceInlineCreate()
        {
        }

    }
}