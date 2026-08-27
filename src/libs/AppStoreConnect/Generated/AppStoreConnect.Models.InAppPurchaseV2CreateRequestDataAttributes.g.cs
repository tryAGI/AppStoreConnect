
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InAppPurchaseV2CreateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProductId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inAppPurchaseType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.InAppPurchaseType2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.InAppPurchaseType2 InAppPurchaseType { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseV2CreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="productId"></param>
        /// <param name="inAppPurchaseType"></param>
        /// <param name="reviewNote"></param>
        /// <param name="familySharable"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchaseV2CreateRequestDataAttributes(
            string name,
            string productId,
            global::AppStoreConnect.InAppPurchaseType2 inAppPurchaseType,
            string? reviewNote,
            bool? familySharable)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ProductId = productId ?? throw new global::System.ArgumentNullException(nameof(productId));
            this.InAppPurchaseType = inAppPurchaseType;
            this.ReviewNote = reviewNote;
            this.FamilySharable = familySharable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseV2CreateRequestDataAttributes" /> class.
        /// </summary>
        public InAppPurchaseV2CreateRequestDataAttributes()
        {
        }

    }
}