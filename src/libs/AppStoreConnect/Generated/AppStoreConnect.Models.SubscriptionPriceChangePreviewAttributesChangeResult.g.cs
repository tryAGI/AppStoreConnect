
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionPriceChangePreviewAttributesChangeResult
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("territoryId")]
        public string? TerritoryId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changeType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SubscriptionPriceChangePreviewAttributesChangeResultChangeTypeJsonConverter))]
        public global::AppStoreConnect.SubscriptionPriceChangePreviewAttributesChangeResultChangeType? ChangeType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPriceChangePreviewAttributesChangeResult" /> class.
        /// </summary>
        /// <param name="territoryId"></param>
        /// <param name="changeType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionPriceChangePreviewAttributesChangeResult(
            string? territoryId,
            global::AppStoreConnect.SubscriptionPriceChangePreviewAttributesChangeResultChangeType? changeType)
        {
            this.TerritoryId = territoryId;
            this.ChangeType = changeType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPriceChangePreviewAttributesChangeResult" /> class.
        /// </summary>
        public SubscriptionPriceChangePreviewAttributesChangeResult()
        {
        }

    }
}