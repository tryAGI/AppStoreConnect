
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ScmPullRequestRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        public global::AppStoreConnect.ScmPullRequestRelationshipsRepository? Repository { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScmPullRequestRelationships" /> class.
        /// </summary>
        /// <param name="repository"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScmPullRequestRelationships(
            global::AppStoreConnect.ScmPullRequestRelationshipsRepository? repository)
        {
            this.Repository = repository;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScmPullRequestRelationships" /> class.
        /// </summary>
        public ScmPullRequestRelationships()
        {
        }

    }
}