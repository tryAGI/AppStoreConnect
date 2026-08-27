
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        public global::AppStoreConnect.WebhookRelationshipsApp? App { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deliveries")]
        public global::AppStoreConnect.WebhookRelationshipsDeliveries? Deliveries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRelationships" /> class.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="deliveries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookRelationships(
            global::AppStoreConnect.WebhookRelationshipsApp? app,
            global::AppStoreConnect.WebhookRelationshipsDeliveries? deliveries)
        {
            this.App = app;
            this.Deliveries = deliveries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRelationships" /> class.
        /// </summary>
        public WebhookRelationships()
        {
        }

    }
}