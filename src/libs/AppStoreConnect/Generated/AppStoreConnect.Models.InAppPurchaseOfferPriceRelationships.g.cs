
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InAppPurchaseOfferPriceRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("territory")]
        public global::AppStoreConnect.InAppPurchaseOfferPriceRelationshipsTerritory? Territory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricePoint")]
        public global::AppStoreConnect.InAppPurchaseOfferPriceRelationshipsPricePoint? PricePoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseOfferPriceRelationships" /> class.
        /// </summary>
        /// <param name="territory"></param>
        /// <param name="pricePoint"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchaseOfferPriceRelationships(
            global::AppStoreConnect.InAppPurchaseOfferPriceRelationshipsTerritory? territory,
            global::AppStoreConnect.InAppPurchaseOfferPriceRelationshipsPricePoint? pricePoint)
        {
            this.Territory = territory;
            this.PricePoint = pricePoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseOfferPriceRelationships" /> class.
        /// </summary>
        public InAppPurchaseOfferPriceRelationships()
        {
        }

    }
}