
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriptionVersionRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        public global::AppStoreConnect.SubscriptionVersionRelationshipsSubscription? Subscription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::AppStoreConnect.SubscriptionVersionRelationshipsImage? Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::AppStoreConnect.SubscriptionVersionRelationshipsImages? Images { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("localizations")]
        public global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizations? Localizations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionVersionRelationships" /> class.
        /// </summary>
        /// <param name="subscription"></param>
        /// <param name="image"></param>
        /// <param name="images"></param>
        /// <param name="localizations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionVersionRelationships(
            global::AppStoreConnect.SubscriptionVersionRelationshipsSubscription? subscription,
            global::AppStoreConnect.SubscriptionVersionRelationshipsImage? image,
            global::AppStoreConnect.SubscriptionVersionRelationshipsImages? images,
            global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizations? localizations)
        {
            this.Subscription = subscription;
            this.Image = image;
            this.Images = images;
            this.Localizations = localizations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionVersionRelationships" /> class.
        /// </summary>
        public SubscriptionVersionRelationships()
        {
        }

    }
}