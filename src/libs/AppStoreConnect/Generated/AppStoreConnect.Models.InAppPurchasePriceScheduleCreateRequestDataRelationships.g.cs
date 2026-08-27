
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InAppPurchasePriceScheduleCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inAppPurchase")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationshipsInAppPurchase InAppPurchase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseTerritory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationshipsBaseTerritory BaseTerritory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manualPrices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationshipsManualPrices ManualPrices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchasePriceScheduleCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="inAppPurchase"></param>
        /// <param name="baseTerritory"></param>
        /// <param name="manualPrices"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchasePriceScheduleCreateRequestDataRelationships(
            global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationshipsInAppPurchase inAppPurchase,
            global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationshipsBaseTerritory baseTerritory,
            global::AppStoreConnect.InAppPurchasePriceScheduleCreateRequestDataRelationshipsManualPrices manualPrices)
        {
            this.InAppPurchase = inAppPurchase ?? throw new global::System.ArgumentNullException(nameof(inAppPurchase));
            this.BaseTerritory = baseTerritory ?? throw new global::System.ArgumentNullException(nameof(baseTerritory));
            this.ManualPrices = manualPrices ?? throw new global::System.ArgumentNullException(nameof(manualPrices));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchasePriceScheduleCreateRequestDataRelationships" /> class.
        /// </summary>
        public InAppPurchasePriceScheduleCreateRequestDataRelationships()
        {
        }

    }
}