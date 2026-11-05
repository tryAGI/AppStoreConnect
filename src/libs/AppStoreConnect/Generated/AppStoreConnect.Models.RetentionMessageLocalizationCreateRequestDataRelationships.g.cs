
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RetentionMessageLocalizationCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retentionMessageVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.RetentionMessageLocalizationCreateRequestDataRelationshipsRetentionMessageVersion RetentionMessageVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionMessageLocalizationCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="retentionMessageVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetentionMessageLocalizationCreateRequestDataRelationships(
            global::AppStoreConnect.RetentionMessageLocalizationCreateRequestDataRelationshipsRetentionMessageVersion retentionMessageVersion)
        {
            this.RetentionMessageVersion = retentionMessageVersion ?? throw new global::System.ArgumentNullException(nameof(retentionMessageVersion));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionMessageLocalizationCreateRequestDataRelationships" /> class.
        /// </summary>
        public RetentionMessageLocalizationCreateRequestDataRelationships()
        {
        }

    }
}