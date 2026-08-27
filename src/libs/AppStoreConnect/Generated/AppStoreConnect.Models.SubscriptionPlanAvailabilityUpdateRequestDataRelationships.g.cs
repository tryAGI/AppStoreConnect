
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionPlanAvailabilityUpdateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("availableTerritories")]
        public global::AppStoreConnect.SubscriptionPlanAvailabilityUpdateRequestDataRelationshipsAvailableTerritories? AvailableTerritories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPlanAvailabilityUpdateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="availableTerritories"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionPlanAvailabilityUpdateRequestDataRelationships(
            global::AppStoreConnect.SubscriptionPlanAvailabilityUpdateRequestDataRelationshipsAvailableTerritories? availableTerritories)
        {
            this.AvailableTerritories = availableTerritories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPlanAvailabilityUpdateRequestDataRelationships" /> class.
        /// </summary>
        public SubscriptionPlanAvailabilityUpdateRequestDataRelationships()
        {
        }

    }
}