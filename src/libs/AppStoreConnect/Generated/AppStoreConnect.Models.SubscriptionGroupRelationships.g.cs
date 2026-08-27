
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionGroupRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptions")]
        public global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptions? Subscriptions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionGroupLocalizations")]
        public global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizations? SubscriptionGroupLocalizations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        public global::AppStoreConnect.SubscriptionGroupRelationshipsVersions? Versions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupRelationships" /> class.
        /// </summary>
        /// <param name="subscriptions"></param>
        /// <param name="subscriptionGroupLocalizations"></param>
        /// <param name="versions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionGroupRelationships(
            global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptions? subscriptions,
            global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizations? subscriptionGroupLocalizations,
            global::AppStoreConnect.SubscriptionGroupRelationshipsVersions? versions)
        {
            this.Subscriptions = subscriptions;
            this.SubscriptionGroupLocalizations = subscriptionGroupLocalizations;
            this.Versions = versions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupRelationships" /> class.
        /// </summary>
        public SubscriptionGroupRelationships()
        {
        }

    }
}