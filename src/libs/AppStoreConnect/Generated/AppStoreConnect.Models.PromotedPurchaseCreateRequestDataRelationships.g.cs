
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromotedPurchaseCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.PromotedPurchaseCreateRequestDataRelationshipsApp App { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inAppPurchaseV2")]
        public global::AppStoreConnect.PromotedPurchaseCreateRequestDataRelationshipsInAppPurchaseV2? InAppPurchaseV2 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        public global::AppStoreConnect.PromotedPurchaseCreateRequestDataRelationshipsSubscription? Subscription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromotedPurchaseCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="inAppPurchaseV2"></param>
        /// <param name="subscription"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromotedPurchaseCreateRequestDataRelationships(
            global::AppStoreConnect.PromotedPurchaseCreateRequestDataRelationshipsApp app,
            global::AppStoreConnect.PromotedPurchaseCreateRequestDataRelationshipsInAppPurchaseV2? inAppPurchaseV2,
            global::AppStoreConnect.PromotedPurchaseCreateRequestDataRelationshipsSubscription? subscription)
        {
            this.App = app ?? throw new global::System.ArgumentNullException(nameof(app));
            this.InAppPurchaseV2 = inAppPurchaseV2;
            this.Subscription = subscription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromotedPurchaseCreateRequestDataRelationships" /> class.
        /// </summary>
        public PromotedPurchaseCreateRequestDataRelationships()
        {
        }

    }
}