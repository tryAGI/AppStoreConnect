
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RetentionMessageLocalizationRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retentionMessageVersion")]
        public global::AppStoreConnect.RetentionMessageLocalizationRelationshipsRetentionMessageVersion? RetentionMessageVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionMessageLocalizationRelationships" /> class.
        /// </summary>
        /// <param name="retentionMessageVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetentionMessageLocalizationRelationships(
            global::AppStoreConnect.RetentionMessageLocalizationRelationshipsRetentionMessageVersion? retentionMessageVersion)
        {
            this.RetentionMessageVersion = retentionMessageVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionMessageLocalizationRelationships" /> class.
        /// </summary>
        public RetentionMessageLocalizationRelationships()
        {
        }

    }
}