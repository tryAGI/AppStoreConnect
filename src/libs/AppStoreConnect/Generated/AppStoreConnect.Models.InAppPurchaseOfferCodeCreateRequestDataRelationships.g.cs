
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InAppPurchaseOfferCodeCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inAppPurchase")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.InAppPurchaseOfferCodeCreateRequestDataRelationshipsInAppPurchase InAppPurchase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.InAppPurchaseOfferCodeCreateRequestDataRelationshipsPrices Prices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseOfferCodeCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="inAppPurchase"></param>
        /// <param name="prices"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchaseOfferCodeCreateRequestDataRelationships(
            global::AppStoreConnect.InAppPurchaseOfferCodeCreateRequestDataRelationshipsInAppPurchase inAppPurchase,
            global::AppStoreConnect.InAppPurchaseOfferCodeCreateRequestDataRelationshipsPrices prices)
        {
            this.InAppPurchase = inAppPurchase ?? throw new global::System.ArgumentNullException(nameof(inAppPurchase));
            this.Prices = prices ?? throw new global::System.ArgumentNullException(nameof(prices));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseOfferCodeCreateRequestDataRelationships" /> class.
        /// </summary>
        public InAppPurchaseOfferCodeCreateRequestDataRelationships()
        {
        }

    }
}