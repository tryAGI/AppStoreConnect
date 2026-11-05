
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RetentionMessageRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        public global::AppStoreConnect.RetentionMessageRelationshipsVersions? Versions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptions")]
        public global::AppStoreConnect.RetentionMessageRelationshipsSubscriptions? Subscriptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionMessageRelationships" /> class.
        /// </summary>
        /// <param name="versions"></param>
        /// <param name="subscriptions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetentionMessageRelationships(
            global::AppStoreConnect.RetentionMessageRelationshipsVersions? versions,
            global::AppStoreConnect.RetentionMessageRelationshipsSubscriptions? subscriptions)
        {
            this.Versions = versions;
            this.Subscriptions = subscriptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionMessageRelationships" /> class.
        /// </summary>
        public RetentionMessageRelationships()
        {
        }

    }
}