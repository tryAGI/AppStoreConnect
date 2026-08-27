
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ScmRepositoryAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastAccessedDate")]
        public global::System.DateTime? LastAccessedDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("httpCloneUrl")]
        public string? HttpCloneUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sshCloneUrl")]
        public string? SshCloneUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerName")]
        public string? OwnerName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositoryName")]
        public string? RepositoryName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScmRepositoryAttributes" /> class.
        /// </summary>
        /// <param name="lastAccessedDate"></param>
        /// <param name="httpCloneUrl"></param>
        /// <param name="sshCloneUrl"></param>
        /// <param name="ownerName"></param>
        /// <param name="repositoryName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScmRepositoryAttributes(
            global::System.DateTime? lastAccessedDate,
            string? httpCloneUrl,
            string? sshCloneUrl,
            string? ownerName,
            string? repositoryName)
        {
            this.LastAccessedDate = lastAccessedDate;
            this.HttpCloneUrl = httpCloneUrl;
            this.SshCloneUrl = sshCloneUrl;
            this.OwnerName = ownerName;
            this.RepositoryName = repositoryName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScmRepositoryAttributes" /> class.
        /// </summary>
        public ScmRepositoryAttributes()
        {
        }

    }
}