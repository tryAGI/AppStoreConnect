
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriptionPlanAvailabilityCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("availableTerritories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.SubscriptionPlanAvailabilityCreateRequestDataRelationshipsAvailableTerritories AvailableTerritories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.SubscriptionPlanAvailabilityCreateRequestDataRelationshipsSubscription Subscription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPlanAvailabilityCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="availableTerritories"></param>
        /// <param name="subscription"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionPlanAvailabilityCreateRequestDataRelationships(
            global::AppStoreConnect.SubscriptionPlanAvailabilityCreateRequestDataRelationshipsAvailableTerritories availableTerritories,
            global::AppStoreConnect.SubscriptionPlanAvailabilityCreateRequestDataRelationshipsSubscription subscription)
        {
            this.AvailableTerritories = availableTerritories ?? throw new global::System.ArgumentNullException(nameof(availableTerritories));
            this.Subscription = subscription ?? throw new global::System.ArgumentNullException(nameof(subscription));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPlanAvailabilityCreateRequestDataRelationships" /> class.
        /// </summary>
        public SubscriptionPlanAvailabilityCreateRequestDataRelationships()
        {
        }

    }
}