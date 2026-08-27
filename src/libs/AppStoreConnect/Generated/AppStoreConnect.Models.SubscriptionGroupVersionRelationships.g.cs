
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionGroupVersionRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionGroup")]
        public global::AppStoreConnect.SubscriptionGroupVersionRelationshipsSubscriptionGroup? SubscriptionGroup { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("localizations")]
        public global::AppStoreConnect.SubscriptionGroupVersionRelationshipsLocalizations? Localizations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupVersionRelationships" /> class.
        /// </summary>
        /// <param name="subscriptionGroup"></param>
        /// <param name="localizations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionGroupVersionRelationships(
            global::AppStoreConnect.SubscriptionGroupVersionRelationshipsSubscriptionGroup? subscriptionGroup,
            global::AppStoreConnect.SubscriptionGroupVersionRelationshipsLocalizations? localizations)
        {
            this.SubscriptionGroup = subscriptionGroup;
            this.Localizations = localizations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupVersionRelationships" /> class.
        /// </summary>
        public SubscriptionGroupVersionRelationships()
        {
        }

    }
}