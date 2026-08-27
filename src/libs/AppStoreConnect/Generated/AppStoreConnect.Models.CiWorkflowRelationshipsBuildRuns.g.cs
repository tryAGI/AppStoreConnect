
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CiWorkflowRelationshipsBuildRuns
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        public global::AppStoreConnect.RelationshipLinks? Links { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiWorkflowRelationshipsBuildRuns" /> class.
        /// </summary>
        /// <param name="links"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiWorkflowRelationshipsBuildRuns(
            global::AppStoreConnect.RelationshipLinks? links)
        {
            this.Links = links;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiWorkflowRelationshipsBuildRuns" /> class.
        /// </summary>
        public CiWorkflowRelationshipsBuildRuns()
        {
        }

    }
}