
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InAppPurchasePriceInlineCreateRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inAppPurchaseV2")]
        public global::AppStoreConnect.InAppPurchasePriceInlineCreateRelationshipsInAppPurchaseV2? InAppPurchaseV2 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inAppPurchasePricePoint")]
        public global::AppStoreConnect.InAppPurchasePriceInlineCreateRelationshipsInAppPurchasePricePoint? InAppPurchasePricePoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchasePriceInlineCreateRelationships" /> class.
        /// </summary>
        /// <param name="inAppPurchaseV2"></param>
        /// <param name="inAppPurchasePricePoint"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchasePriceInlineCreateRelationships(
            global::AppStoreConnect.InAppPurchasePriceInlineCreateRelationshipsInAppPurchaseV2? inAppPurchaseV2,
            global::AppStoreConnect.InAppPurchasePriceInlineCreateRelationshipsInAppPurchasePricePoint? inAppPurchasePricePoint)
        {
            this.InAppPurchaseV2 = inAppPurchaseV2;
            this.InAppPurchasePricePoint = inAppPurchasePricePoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchasePriceInlineCreateRelationships" /> class.
        /// </summary>
        public InAppPurchasePriceInlineCreateRelationships()
        {
        }

    }
}