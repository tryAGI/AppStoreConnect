
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriptionGroupVersionCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionGroup")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.SubscriptionGroupVersionCreateRequestDataRelationshipsSubscriptionGroup SubscriptionGroup { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupVersionCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="subscriptionGroup"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionGroupVersionCreateRequestDataRelationships(
            global::AppStoreConnect.SubscriptionGroupVersionCreateRequestDataRelationshipsSubscriptionGroup subscriptionGroup)
        {
            this.SubscriptionGroup = subscriptionGroup ?? throw new global::System.ArgumentNullException(nameof(subscriptionGroup));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupVersionCreateRequestDataRelationships" /> class.
        /// </summary>
        public SubscriptionGroupVersionCreateRequestDataRelationships()
        {
        }

    }
}