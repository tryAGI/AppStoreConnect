
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CiBuildRunAttributesDestinationCommit
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commitSha")]
        public string? CommitSha { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        public global::AppStoreConnect.CiGitUser? Author { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("committer")]
        public global::AppStoreConnect.CiGitUser? Committer { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webUrl")]
        public string? WebUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiBuildRunAttributesDestinationCommit" /> class.
        /// </summary>
        /// <param name="commitSha"></param>
        /// <param name="message"></param>
        /// <param name="author"></param>
        /// <param name="committer"></param>
        /// <param name="webUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiBuildRunAttributesDestinationCommit(
            string? commitSha,
            string? message,
            global::AppStoreConnect.CiGitUser? author,
            global::AppStoreConnect.CiGitUser? committer,
            string? webUrl)
        {
            this.CommitSha = commitSha;
            this.Message = message;
            this.Author = author;
            this.Committer = committer;
            this.WebUrl = webUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiBuildRunAttributesDestinationCommit" /> class.
        /// </summary>
        public CiBuildRunAttributesDestinationCommit()
        {
        }

    }
}