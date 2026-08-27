
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionGroupLocalizationRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionGroup")]
        public global::AppStoreConnect.SubscriptionGroupLocalizationRelationshipsSubscriptionGroup? SubscriptionGroup { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupLocalizationRelationships" /> class.
        /// </summary>
        /// <param name="subscriptionGroup"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionGroupLocalizationRelationships(
            global::AppStoreConnect.SubscriptionGroupLocalizationRelationshipsSubscriptionGroup? subscriptionGroup)
        {
            this.SubscriptionGroup = subscriptionGroup;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupLocalizationRelationships" /> class.
        /// </summary>
        public SubscriptionGroupLocalizationRelationships()
        {
        }

    }
}