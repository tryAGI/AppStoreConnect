
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScmGitReferenceRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        public global::AppStoreConnect.ScmGitReferenceRelationshipsRepository? Repository { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScmGitReferenceRelationships" /> class.
        /// </summary>
        /// <param name="repository"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScmGitReferenceRelationships(
            global::AppStoreConnect.ScmGitReferenceRelationshipsRepository? repository)
        {
            this.Repository = repository;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScmGitReferenceRelationships" /> class.
        /// </summary>
        public ScmGitReferenceRelationships()
        {
        }

    }
}