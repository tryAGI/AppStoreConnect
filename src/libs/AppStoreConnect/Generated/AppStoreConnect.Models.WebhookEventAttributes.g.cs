
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookEventAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.WebhookEventType2JsonConverter))]
        public global::AppStoreConnect.WebhookEventType2? EventType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public string? Payload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ping")]
        public bool? Ping { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdDate")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEventAttributes" /> class.
        /// </summary>
        /// <param name="eventType"></param>
        /// <param name="payload"></param>
        /// <param name="ping"></param>
        /// <param name="createdDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookEventAttributes(
            global::AppStoreConnect.WebhookEventType2? eventType,
            string? payload,
            bool? ping,
            global::System.DateTime? createdDate)
        {
            this.EventType = eventType;
            this.Payload = payload;
            this.Ping = ping;
            this.CreatedDate = createdDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEventAttributes" /> class.
        /// </summary>
        public WebhookEventAttributes()
        {
        }

    }
}