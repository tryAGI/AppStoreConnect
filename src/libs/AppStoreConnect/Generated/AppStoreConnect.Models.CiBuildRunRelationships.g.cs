
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CiBuildRunRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builds")]
        public global::AppStoreConnect.CiBuildRunRelationshipsBuilds? Builds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow")]
        public global::AppStoreConnect.CiBuildRunRelationshipsWorkflow? Workflow { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product")]
        public global::AppStoreConnect.CiBuildRunRelationshipsProduct? Product { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceBranchOrTag")]
        public global::AppStoreConnect.CiBuildRunRelationshipsSourceBranchOrTag? SourceBranchOrTag { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destinationBranch")]
        public global::AppStoreConnect.CiBuildRunRelationshipsDestinationBranch? DestinationBranch { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        public global::AppStoreConnect.CiBuildRunRelationshipsActions? Actions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pullRequest")]
        public global::AppStoreConnect.CiBuildRunRelationshipsPullRequest? PullRequest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiBuildRunRelationships" /> class.
        /// </summary>
        /// <param name="builds"></param>
        /// <param name="workflow"></param>
        /// <param name="product"></param>
        /// <param name="sourceBranchOrTag"></param>
        /// <param name="destinationBranch"></param>
        /// <param name="actions"></param>
        /// <param name="pullRequest"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiBuildRunRelationships(
            global::AppStoreConnect.CiBuildRunRelationshipsBuilds? builds,
            global::AppStoreConnect.CiBuildRunRelationshipsWorkflow? workflow,
            global::AppStoreConnect.CiBuildRunRelationshipsProduct? product,
            global::AppStoreConnect.CiBuildRunRelationshipsSourceBranchOrTag? sourceBranchOrTag,
            global::AppStoreConnect.CiBuildRunRelationshipsDestinationBranch? destinationBranch,
            global::AppStoreConnect.CiBuildRunRelationshipsActions? actions,
            global::AppStoreConnect.CiBuildRunRelationshipsPullRequest? pullRequest)
        {
            this.Builds = builds;
            this.Workflow = workflow;
            this.Product = product;
            this.SourceBranchOrTag = sourceBranchOrTag;
            this.DestinationBranch = destinationBranch;
            this.Actions = actions;
            this.PullRequest = pullRequest;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiBuildRunRelationships" /> class.
        /// </summary>
        public CiBuildRunRelationships()
        {
        }

    }
}