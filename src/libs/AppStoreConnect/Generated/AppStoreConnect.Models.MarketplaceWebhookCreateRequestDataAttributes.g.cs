
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MarketplaceWebhookCreateRequestDataAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpointUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndpointUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Secret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceWebhookCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="endpointUrl"></param>
        /// <param name="secret"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MarketplaceWebhookCreateRequestDataAttributes(
            string endpointUrl,
            string secret)
        {
            this.EndpointUrl = endpointUrl ?? throw new global::System.ArgumentNullException(nameof(endpointUrl));
            this.Secret = secret ?? throw new global::System.ArgumentNullException(nameof(secret));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceWebhookCreateRequestDataAttributes" /> class.
        /// </summary>
        public MarketplaceWebhookCreateRequestDataAttributes()
        {
        }

    }
}