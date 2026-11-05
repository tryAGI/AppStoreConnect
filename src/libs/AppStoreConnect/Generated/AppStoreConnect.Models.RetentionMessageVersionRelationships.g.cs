
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RetentionMessageVersionRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retentionMessage")]
        public global::AppStoreConnect.RetentionMessageVersionRelationshipsRetentionMessage? RetentionMessage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("localizations")]
        public global::AppStoreConnect.RetentionMessageVersionRelationshipsLocalizations? Localizations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placement")]
        public global::AppStoreConnect.RetentionMessageVersionRelationshipsPlacement? Placement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionMessageVersionRelationships" /> class.
        /// </summary>
        /// <param name="retentionMessage"></param>
        /// <param name="localizations"></param>
        /// <param name="placement"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetentionMessageVersionRelationships(
            global::AppStoreConnect.RetentionMessageVersionRelationshipsRetentionMessage? retentionMessage,
            global::AppStoreConnect.RetentionMessageVersionRelationshipsLocalizations? localizations,
            global::AppStoreConnect.RetentionMessageVersionRelationshipsPlacement? placement)
        {
            this.RetentionMessage = retentionMessage;
            this.Localizations = localizations;
            this.Placement = placement;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionMessageVersionRelationships" /> class.
        /// </summary>
        public RetentionMessageVersionRelationships()
        {
        }

    }
}