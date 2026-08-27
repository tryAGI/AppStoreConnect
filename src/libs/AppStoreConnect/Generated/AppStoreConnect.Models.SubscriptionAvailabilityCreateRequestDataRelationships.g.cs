
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriptionAvailabilityCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.SubscriptionAvailabilityCreateRequestDataRelationshipsSubscription Subscription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("availableTerritories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.SubscriptionAvailabilityCreateRequestDataRelationshipsAvailableTerritories AvailableTerritories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionAvailabilityCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="subscription"></param>
        /// <param name="availableTerritories"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionAvailabilityCreateRequestDataRelationships(
            global::AppStoreConnect.SubscriptionAvailabilityCreateRequestDataRelationshipsSubscription subscription,
            global::AppStoreConnect.SubscriptionAvailabilityCreateRequestDataRelationshipsAvailableTerritories availableTerritories)
        {
            this.Subscription = subscription ?? throw new global::System.ArgumentNullException(nameof(subscription));
            this.AvailableTerritories = availableTerritories ?? throw new global::System.ArgumentNullException(nameof(availableTerritories));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionAvailabilityCreateRequestDataRelationships" /> class.
        /// </summary>
        public SubscriptionAvailabilityCreateRequestDataRelationships()
        {
        }

    }
}