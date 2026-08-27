
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InAppPurchasePriceRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inAppPurchasePricePoint")]
        public global::AppStoreConnect.InAppPurchasePriceRelationshipsInAppPurchasePricePoint? InAppPurchasePricePoint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("territory")]
        public global::AppStoreConnect.InAppPurchasePriceRelationshipsTerritory? Territory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchasePriceRelationships" /> class.
        /// </summary>
        /// <param name="inAppPurchasePricePoint"></param>
        /// <param name="territory"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchasePriceRelationships(
            global::AppStoreConnect.InAppPurchasePriceRelationshipsInAppPurchasePricePoint? inAppPurchasePricePoint,
            global::AppStoreConnect.InAppPurchasePriceRelationshipsTerritory? territory)
        {
            this.InAppPurchasePricePoint = inAppPurchasePricePoint;
            this.Territory = territory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchasePriceRelationships" /> class.
        /// </summary>
        public InAppPurchasePriceRelationships()
        {
        }

    }
}