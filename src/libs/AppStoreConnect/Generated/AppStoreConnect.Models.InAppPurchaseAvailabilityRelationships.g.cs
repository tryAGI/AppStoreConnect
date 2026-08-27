
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InAppPurchaseAvailabilityRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("availableTerritories")]
        public global::AppStoreConnect.InAppPurchaseAvailabilityRelationshipsAvailableTerritories? AvailableTerritories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseAvailabilityRelationships" /> class.
        /// </summary>
        /// <param name="availableTerritories"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchaseAvailabilityRelationships(
            global::AppStoreConnect.InAppPurchaseAvailabilityRelationshipsAvailableTerritories? availableTerritories)
        {
            this.AvailableTerritories = availableTerritories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseAvailabilityRelationships" /> class.
        /// </summary>
        public InAppPurchaseAvailabilityRelationships()
        {
        }

    }
}