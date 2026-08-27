
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InAppPurchaseV2Attributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productId")]
        public string? ProductId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inAppPurchaseType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.InAppPurchaseType2JsonConverter))]
        public global::AppStoreConnect.InAppPurchaseType2? InAppPurchaseType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.InAppPurchaseStateJsonConverter))]
        public global::AppStoreConnect.InAppPurchaseState? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewNote")]
        public string? ReviewNote { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("familySharable")]
        public bool? FamilySharable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentHosting")]
        public bool? ContentHosting { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseV2Attributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="productId"></param>
        /// <param name="inAppPurchaseType"></param>
        /// <param name="state"></param>
        /// <param name="reviewNote"></param>
        /// <param name="familySharable"></param>
        /// <param name="contentHosting"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchaseV2Attributes(
            string? name,
            string? productId,
            global::AppStoreConnect.InAppPurchaseType2? inAppPurchaseType,
            global::AppStoreConnect.InAppPurchaseState? state,
            string? reviewNote,
            bool? familySharable,
            bool? contentHosting)
        {
            this.Name = name;
            this.ProductId = productId;
            this.InAppPurchaseType = inAppPurchaseType;
            this.State = state;
            this.ReviewNote = reviewNote;
            this.FamilySharable = familySharable;
            this.ContentHosting = contentHosting;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseV2Attributes" /> class.
        /// </summary>
        public InAppPurchaseV2Attributes()
        {
        }

    }
}