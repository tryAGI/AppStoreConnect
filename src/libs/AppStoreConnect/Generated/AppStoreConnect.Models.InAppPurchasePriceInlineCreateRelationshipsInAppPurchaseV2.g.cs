
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InAppPurchasePriceInlineCreateRelationshipsInAppPurchaseV2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::AppStoreConnect.InAppPurchasePriceInlineCreateRelationshipsInAppPurchaseV2Data? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchasePriceInlineCreateRelationshipsInAppPurchaseV2" /> class.
        /// </summary>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchasePriceInlineCreateRelationshipsInAppPurchaseV2(
            global::AppStoreConnect.InAppPurchasePriceInlineCreateRelationshipsInAppPurchaseV2Data? data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchasePriceInlineCreateRelationshipsInAppPurchaseV2" /> class.
        /// </summary>
        public InAppPurchasePriceInlineCreateRelationshipsInAppPurchaseV2()
        {
        }

    }
}