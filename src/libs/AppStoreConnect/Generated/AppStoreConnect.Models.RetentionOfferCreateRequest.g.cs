
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RetentionOfferCreateRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.RetentionOfferCreateRequestData Data { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("included")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionOfferPriceInlineCreate>? Included { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionOfferCreateRequest" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="included"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetentionOfferCreateRequest(
            global::AppStoreConnect.RetentionOfferCreateRequestData data,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionOfferPriceInlineCreate>? included)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Included = included;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionOfferCreateRequest" /> class.
        /// </summary>
        public RetentionOfferCreateRequest()
        {
        }

    }
}