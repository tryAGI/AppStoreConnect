
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CiBuildActionRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildRun")]
        public global::AppStoreConnect.CiBuildActionRelationshipsBuildRun? BuildRun { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifacts")]
        public global::AppStoreConnect.CiBuildActionRelationshipsArtifacts? Artifacts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        public global::AppStoreConnect.CiBuildActionRelationshipsIssues? Issues { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("testResults")]
        public global::AppStoreConnect.CiBuildActionRelationshipsTestResults? TestResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiBuildActionRelationships" /> class.
        /// </summary>
        /// <param name="buildRun"></param>
        /// <param name="artifacts"></param>
        /// <param name="issues"></param>
        /// <param name="testResults"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiBuildActionRelationships(
            global::AppStoreConnect.CiBuildActionRelationshipsBuildRun? buildRun,
            global::AppStoreConnect.CiBuildActionRelationshipsArtifacts? artifacts,
            global::AppStoreConnect.CiBuildActionRelationshipsIssues? issues,
            global::AppStoreConnect.CiBuildActionRelationshipsTestResults? testResults)
        {
            this.BuildRun = buildRun;
            this.Artifacts = artifacts;
            this.Issues = issues;
            this.TestResults = testResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiBuildActionRelationships" /> class.
        /// </summary>
        public CiBuildActionRelationships()
        {
        }

    }
}