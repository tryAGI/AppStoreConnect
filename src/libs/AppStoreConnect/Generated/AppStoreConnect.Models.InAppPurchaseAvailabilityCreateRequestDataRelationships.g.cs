
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InAppPurchaseAvailabilityCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inAppPurchase")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.InAppPurchaseAvailabilityCreateRequestDataRelationshipsInAppPurchase InAppPurchase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("availableTerritories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.InAppPurchaseAvailabilityCreateRequestDataRelationshipsAvailableTerritories AvailableTerritories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseAvailabilityCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="inAppPurchase"></param>
        /// <param name="availableTerritories"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchaseAvailabilityCreateRequestDataRelationships(
            global::AppStoreConnect.InAppPurchaseAvailabilityCreateRequestDataRelationshipsInAppPurchase inAppPurchase,
            global::AppStoreConnect.InAppPurchaseAvailabilityCreateRequestDataRelationshipsAvailableTerritories availableTerritories)
        {
            this.InAppPurchase = inAppPurchase ?? throw new global::System.ArgumentNullException(nameof(inAppPurchase));
            this.AvailableTerritories = availableTerritories ?? throw new global::System.ArgumentNullException(nameof(availableTerritories));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseAvailabilityCreateRequestDataRelationships" /> class.
        /// </summary>
        public InAppPurchaseAvailabilityCreateRequestDataRelationships()
        {
        }

    }
}