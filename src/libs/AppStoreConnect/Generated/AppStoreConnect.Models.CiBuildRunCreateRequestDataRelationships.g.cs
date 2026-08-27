
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CiBuildRunCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildRun")]
        public global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsBuildRun? BuildRun { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow")]
        public global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsWorkflow? Workflow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceBranchOrTag")]
        public global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTag? SourceBranchOrTag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pullRequest")]
        public global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsPullRequest? PullRequest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiBuildRunCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="buildRun"></param>
        /// <param name="workflow"></param>
        /// <param name="sourceBranchOrTag"></param>
        /// <param name="pullRequest"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiBuildRunCreateRequestDataRelationships(
            global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsBuildRun? buildRun,
            global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsWorkflow? workflow,
            global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTag? sourceBranchOrTag,
            global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsPullRequest? pullRequest)
        {
            this.BuildRun = buildRun;
            this.Workflow = workflow;
            this.SourceBranchOrTag = sourceBranchOrTag;
            this.PullRequest = pullRequest;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiBuildRunCreateRequestDataRelationships" /> class.
        /// </summary>
        public CiBuildRunCreateRequestDataRelationships()
        {
        }

    }
}