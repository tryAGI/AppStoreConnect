
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromotedPurchaseRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inAppPurchaseV2")]
        public global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2? InAppPurchaseV2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        public global::AppStoreConnect.PromotedPurchaseRelationshipsSubscription? Subscription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromotedPurchaseRelationships" /> class.
        /// </summary>
        /// <param name="inAppPurchaseV2"></param>
        /// <param name="subscription"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromotedPurchaseRelationships(
            global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2? inAppPurchaseV2,
            global::AppStoreConnect.PromotedPurchaseRelationshipsSubscription? subscription)
        {
            this.InAppPurchaseV2 = inAppPurchaseV2;
            this.Subscription = subscription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromotedPurchaseRelationships" /> class.
        /// </summary>
        public PromotedPurchaseRelationships()
        {
        }

    }
}