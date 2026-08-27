
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InAppPurchaseOfferPriceInlineCreateRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("territory")]
        public global::AppStoreConnect.InAppPurchaseOfferPriceInlineCreateRelationshipsTerritory? Territory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricePoint")]
        public global::AppStoreConnect.InAppPurchaseOfferPriceInlineCreateRelationshipsPricePoint? PricePoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseOfferPriceInlineCreateRelationships" /> class.
        /// </summary>
        /// <param name="territory"></param>
        /// <param name="pricePoint"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchaseOfferPriceInlineCreateRelationships(
            global::AppStoreConnect.InAppPurchaseOfferPriceInlineCreateRelationshipsTerritory? territory,
            global::AppStoreConnect.InAppPurchaseOfferPriceInlineCreateRelationshipsPricePoint? pricePoint)
        {
            this.Territory = territory;
            this.PricePoint = pricePoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseOfferPriceInlineCreateRelationships" /> class.
        /// </summary>
        public InAppPurchaseOfferPriceInlineCreateRelationships()
        {
        }

    }
}