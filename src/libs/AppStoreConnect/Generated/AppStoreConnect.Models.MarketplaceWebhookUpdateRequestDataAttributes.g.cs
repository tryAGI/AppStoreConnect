
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MarketplaceWebhookUpdateRequestDataAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpointUrl")]
        public string? EndpointUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public string? Secret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceWebhookUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="endpointUrl"></param>
        /// <param name="secret"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MarketplaceWebhookUpdateRequestDataAttributes(
            string? endpointUrl,
            string? secret)
        {
            this.EndpointUrl = endpointUrl;
            this.Secret = secret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceWebhookUpdateRequestDataAttributes" /> class.
        /// </summary>
        public MarketplaceWebhookUpdateRequestDataAttributes()
        {
        }

    }
}