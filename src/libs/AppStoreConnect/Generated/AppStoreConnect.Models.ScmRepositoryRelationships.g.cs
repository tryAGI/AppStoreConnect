
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScmRepositoryRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scmProvider")]
        public global::AppStoreConnect.ScmRepositoryRelationshipsScmProvider? ScmProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultBranch")]
        public global::AppStoreConnect.ScmRepositoryRelationshipsDefaultBranch? DefaultBranch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitReferences")]
        public global::AppStoreConnect.ScmRepositoryRelationshipsGitReferences? GitReferences { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pullRequests")]
        public global::AppStoreConnect.ScmRepositoryRelationshipsPullRequests? PullRequests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScmRepositoryRelationships" /> class.
        /// </summary>
        /// <param name="scmProvider"></param>
        /// <param name="defaultBranch"></param>
        /// <param name="gitReferences"></param>
        /// <param name="pullRequests"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScmRepositoryRelationships(
            global::AppStoreConnect.ScmRepositoryRelationshipsScmProvider? scmProvider,
            global::AppStoreConnect.ScmRepositoryRelationshipsDefaultBranch? defaultBranch,
            global::AppStoreConnect.ScmRepositoryRelationshipsGitReferences? gitReferences,
            global::AppStoreConnect.ScmRepositoryRelationshipsPullRequests? pullRequests)
        {
            this.ScmProvider = scmProvider;
            this.DefaultBranch = defaultBranch;
            this.GitReferences = gitReferences;
            this.PullRequests = pullRequests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScmRepositoryRelationships" /> class.
        /// </summary>
        public ScmRepositoryRelationships()
        {
        }

    }
}