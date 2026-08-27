
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventTypes")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.WebhookEventType2>? EventTypes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookAttributes" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="eventTypes"></param>
        /// <param name="name"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookAttributes(
            bool? enabled,
            global::System.Collections.Generic.IList<global::AppStoreConnect.WebhookEventType2>? eventTypes,
            string? name,
            string? url)
        {
            this.Enabled = enabled;
            this.EventTypes = eventTypes;
            this.Name = name;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookAttributes" /> class.
        /// </summary>
        public WebhookAttributes()
        {
        }

    }
}