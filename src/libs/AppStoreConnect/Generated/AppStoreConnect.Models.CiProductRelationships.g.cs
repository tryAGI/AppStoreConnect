
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CiProductRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        public global::AppStoreConnect.CiProductRelationshipsApp? App { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bundleId")]
        public global::AppStoreConnect.CiProductRelationshipsBundleId? BundleId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        public global::AppStoreConnect.CiProductRelationshipsWorkflows? Workflows { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primaryRepositories")]
        public global::AppStoreConnect.CiProductRelationshipsPrimaryRepositories? PrimaryRepositories { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additionalRepositories")]
        public global::AppStoreConnect.CiProductRelationshipsAdditionalRepositories? AdditionalRepositories { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildRuns")]
        public global::AppStoreConnect.CiProductRelationshipsBuildRuns? BuildRuns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiProductRelationships" /> class.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="bundleId"></param>
        /// <param name="workflows"></param>
        /// <param name="primaryRepositories"></param>
        /// <param name="additionalRepositories"></param>
        /// <param name="buildRuns"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiProductRelationships(
            global::AppStoreConnect.CiProductRelationshipsApp? app,
            global::AppStoreConnect.CiProductRelationshipsBundleId? bundleId,
            global::AppStoreConnect.CiProductRelationshipsWorkflows? workflows,
            global::AppStoreConnect.CiProductRelationshipsPrimaryRepositories? primaryRepositories,
            global::AppStoreConnect.CiProductRelationshipsAdditionalRepositories? additionalRepositories,
            global::AppStoreConnect.CiProductRelationshipsBuildRuns? buildRuns)
        {
            this.App = app;
            this.BundleId = bundleId;
            this.Workflows = workflows;
            this.PrimaryRepositories = primaryRepositories;
            this.AdditionalRepositories = additionalRepositories;
            this.BuildRuns = buildRuns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiProductRelationships" /> class.
        /// </summary>
        public CiProductRelationships()
        {
        }

    }
}