
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionPlanAvailabilityRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("availableTerritories")]
        public global::AppStoreConnect.SubscriptionPlanAvailabilityRelationshipsAvailableTerritories? AvailableTerritories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPlanAvailabilityRelationships" /> class.
        /// </summary>
        /// <param name="availableTerritories"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionPlanAvailabilityRelationships(
            global::AppStoreConnect.SubscriptionPlanAvailabilityRelationshipsAvailableTerritories? availableTerritories)
        {
            this.AvailableTerritories = availableTerritories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPlanAvailabilityRelationships" /> class.
        /// </summary>
        public SubscriptionPlanAvailabilityRelationships()
        {
        }

    }
}