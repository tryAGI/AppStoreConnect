
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScmProviderRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories")]
        public global::AppStoreConnect.ScmProviderRelationshipsRepositories? Repositories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScmProviderRelationships" /> class.
        /// </summary>
        /// <param name="repositories"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScmProviderRelationships(
            global::AppStoreConnect.ScmProviderRelationshipsRepositories? repositories)
        {
            this.Repositories = repositories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScmProviderRelationships" /> class.
        /// </summary>
        public ScmProviderRelationships()
        {
        }

    }
}