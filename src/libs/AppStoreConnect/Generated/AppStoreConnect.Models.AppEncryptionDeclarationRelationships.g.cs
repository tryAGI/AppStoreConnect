
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppEncryptionDeclarationRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::AppStoreConnect.AppEncryptionDeclarationRelationshipsApp? App { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builds")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::AppStoreConnect.AppEncryptionDeclarationRelationshipsBuilds? Builds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appEncryptionDeclarationDocument")]
        public global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocument? AppEncryptionDeclarationDocument { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEncryptionDeclarationRelationships" /> class.
        /// </summary>
        /// <param name="appEncryptionDeclarationDocument"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppEncryptionDeclarationRelationships(
            global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocument? appEncryptionDeclarationDocument)
        {
            this.AppEncryptionDeclarationDocument = appEncryptionDeclarationDocument;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEncryptionDeclarationRelationships" /> class.
        /// </summary>
        public AppEncryptionDeclarationRelationships()
        {
        }

    }
}