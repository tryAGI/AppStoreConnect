
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InAppPurchasePriceScheduleRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseTerritory")]
        public global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsBaseTerritory? BaseTerritory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manualPrices")]
        public global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsManualPrices? ManualPrices { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("automaticPrices")]
        public global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsAutomaticPrices? AutomaticPrices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchasePriceScheduleRelationships" /> class.
        /// </summary>
        /// <param name="baseTerritory"></param>
        /// <param name="manualPrices"></param>
        /// <param name="automaticPrices"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchasePriceScheduleRelationships(
            global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsBaseTerritory? baseTerritory,
            global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsManualPrices? manualPrices,
            global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsAutomaticPrices? automaticPrices)
        {
            this.BaseTerritory = baseTerritory;
            this.ManualPrices = manualPrices;
            this.AutomaticPrices = automaticPrices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchasePriceScheduleRelationships" /> class.
        /// </summary>
        public InAppPurchasePriceScheduleRelationships()
        {
        }

    }
}