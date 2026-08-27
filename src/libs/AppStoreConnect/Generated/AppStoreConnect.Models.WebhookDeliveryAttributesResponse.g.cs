
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookDeliveryAttributesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("httpStatusCode")]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeliveryAttributesResponse" /> class.
        /// </summary>
        /// <param name="httpStatusCode"></param>
        /// <param name="body"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookDeliveryAttributesResponse(
            int? httpStatusCode,
            string? body)
        {
            this.HttpStatusCode = httpStatusCode;
            this.Body = body;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeliveryAttributesResponse" /> class.
        /// </summary>
        public WebhookDeliveryAttributesResponse()
        {
        }

    }
}