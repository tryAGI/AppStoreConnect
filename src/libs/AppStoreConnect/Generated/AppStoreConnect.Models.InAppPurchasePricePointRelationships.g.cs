
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InAppPurchasePricePointRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("territory")]
        public global::AppStoreConnect.InAppPurchasePricePointRelationshipsTerritory? Territory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("equalizations")]
        public global::AppStoreConnect.InAppPurchasePricePointRelationshipsEqualizations? Equalizations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchasePricePointRelationships" /> class.
        /// </summary>
        /// <param name="territory"></param>
        /// <param name="equalizations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchasePricePointRelationships(
            global::AppStoreConnect.InAppPurchasePricePointRelationshipsTerritory? territory,
            global::AppStoreConnect.InAppPurchasePricePointRelationshipsEqualizations? equalizations)
        {
            this.Territory = territory;
            this.Equalizations = equalizations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchasePricePointRelationships" /> class.
        /// </summary>
        public InAppPurchasePricePointRelationships()
        {
        }

    }
}