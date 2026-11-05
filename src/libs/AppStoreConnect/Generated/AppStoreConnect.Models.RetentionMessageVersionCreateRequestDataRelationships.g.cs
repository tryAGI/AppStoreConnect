
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RetentionMessageVersionCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retentionMessage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.RetentionMessageVersionCreateRequestDataRelationshipsRetentionMessage RetentionMessage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placement")]
        public global::AppStoreConnect.RetentionMessageVersionCreateRequestDataRelationshipsPlacement? Placement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionMessageVersionCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="retentionMessage"></param>
        /// <param name="placement"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetentionMessageVersionCreateRequestDataRelationships(
            global::AppStoreConnect.RetentionMessageVersionCreateRequestDataRelationshipsRetentionMessage retentionMessage,
            global::AppStoreConnect.RetentionMessageVersionCreateRequestDataRelationshipsPlacement? placement)
        {
            this.RetentionMessage = retentionMessage ?? throw new global::System.ArgumentNullException(nameof(retentionMessage));
            this.Placement = placement;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionMessageVersionCreateRequestDataRelationships" /> class.
        /// </summary>
        public RetentionMessageVersionCreateRequestDataRelationships()
        {
        }

    }
}