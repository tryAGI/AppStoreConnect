
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuildUpdateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appEncryptionDeclaration")]
        public global::AppStoreConnect.BuildUpdateRequestDataRelationshipsAppEncryptionDeclaration? AppEncryptionDeclaration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildUpdateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="appEncryptionDeclaration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuildUpdateRequestDataRelationships(
            global::AppStoreConnect.BuildUpdateRequestDataRelationshipsAppEncryptionDeclaration? appEncryptionDeclaration)
        {
            this.AppEncryptionDeclaration = appEncryptionDeclaration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildUpdateRequestDataRelationships" /> class.
        /// </summary>
        public BuildUpdateRequestDataRelationships()
        {
        }

    }
}