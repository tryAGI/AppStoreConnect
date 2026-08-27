
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppEncryptionDeclarationDocumentCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appEncryptionDeclaration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppEncryptionDeclarationDocumentCreateRequestDataRelationshipsAppEncryptionDeclaration AppEncryptionDeclaration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEncryptionDeclarationDocumentCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="appEncryptionDeclaration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppEncryptionDeclarationDocumentCreateRequestDataRelationships(
            global::AppStoreConnect.AppEncryptionDeclarationDocumentCreateRequestDataRelationshipsAppEncryptionDeclaration appEncryptionDeclaration)
        {
            this.AppEncryptionDeclaration = appEncryptionDeclaration ?? throw new global::System.ArgumentNullException(nameof(appEncryptionDeclaration));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEncryptionDeclarationDocumentCreateRequestDataRelationships" /> class.
        /// </summary>
        public AppEncryptionDeclarationDocumentCreateRequestDataRelationships()
        {
        }

    }
}