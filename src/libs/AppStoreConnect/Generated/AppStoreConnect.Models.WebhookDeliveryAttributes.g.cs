
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookDeliveryAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdDate")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deliveryState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.WebhookDeliveryAttributesDeliveryStateJsonConverter))]
        public global::AppStoreConnect.WebhookDeliveryAttributesDeliveryState? DeliveryState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redelivery")]
        public bool? Redelivery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentDate")]
        public global::System.DateTime? SentDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        public global::AppStoreConnect.WebhookDeliveryAttributesRequest? Request { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public global::AppStoreConnect.WebhookDeliveryAttributesResponse? Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeliveryAttributes" /> class.
        /// </summary>
        /// <param name="createdDate"></param>
        /// <param name="deliveryState"></param>
        /// <param name="errorMessage"></param>
        /// <param name="redelivery"></param>
        /// <param name="sentDate"></param>
        /// <param name="request"></param>
        /// <param name="response"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookDeliveryAttributes(
            global::System.DateTime? createdDate,
            global::AppStoreConnect.WebhookDeliveryAttributesDeliveryState? deliveryState,
            string? errorMessage,
            bool? redelivery,
            global::System.DateTime? sentDate,
            global::AppStoreConnect.WebhookDeliveryAttributesRequest? request,
            global::AppStoreConnect.WebhookDeliveryAttributesResponse? response)
        {
            this.CreatedDate = createdDate;
            this.DeliveryState = deliveryState;
            this.ErrorMessage = errorMessage;
            this.Redelivery = redelivery;
            this.SentDate = sentDate;
            this.Request = request;
            this.Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeliveryAttributes" /> class.
        /// </summary>
        public WebhookDeliveryAttributes()
        {
        }

    }
}