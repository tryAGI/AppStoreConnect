
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookDeliveryCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.WebhookDeliveryCreateRequestDataRelationshipsTemplate Template { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeliveryCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="template"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookDeliveryCreateRequestDataRelationships(
            global::AppStoreConnect.WebhookDeliveryCreateRequestDataRelationshipsTemplate template)
        {
            this.Template = template ?? throw new global::System.ArgumentNullException(nameof(template));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeliveryCreateRequestDataRelationships" /> class.
        /// </summary>
        public WebhookDeliveryCreateRequestDataRelationships()
        {
        }

    }
}