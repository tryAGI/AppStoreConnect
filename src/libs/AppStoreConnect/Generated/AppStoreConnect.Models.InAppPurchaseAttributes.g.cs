
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InAppPurchaseAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceName")]
        public string? ReferenceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productId")]
        public string? ProductId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inAppPurchaseType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.InAppPurchaseAttributesInAppPurchaseTypeJsonConverter))]
        public global::AppStoreConnect.InAppPurchaseAttributesInAppPurchaseType? InAppPurchaseType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.InAppPurchaseAttributesStateJsonConverter))]
        public global::AppStoreConnect.InAppPurchaseAttributesState? State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseAttributes" /> class.
        /// </summary>
        /// <param name="referenceName"></param>
        /// <param name="productId"></param>
        /// <param name="inAppPurchaseType"></param>
        /// <param name="state"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchaseAttributes(
            string? referenceName,
            string? productId,
            global::AppStoreConnect.InAppPurchaseAttributesInAppPurchaseType? inAppPurchaseType,
            global::AppStoreConnect.InAppPurchaseAttributesState? state)
        {
            this.ReferenceName = referenceName;
            this.ProductId = productId;
            this.InAppPurchaseType = inAppPurchaseType;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseAttributes" /> class.
        /// </summary>
        public InAppPurchaseAttributes()
        {
        }

    }
}