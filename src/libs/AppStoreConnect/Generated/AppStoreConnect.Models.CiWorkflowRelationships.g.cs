
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CiWorkflowRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product")]
        public global::AppStoreConnect.CiWorkflowRelationshipsProduct? Product { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        public global::AppStoreConnect.CiWorkflowRelationshipsRepository? Repository { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xcodeVersion")]
        public global::AppStoreConnect.CiWorkflowRelationshipsXcodeVersion? XcodeVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("macOsVersion")]
        public global::AppStoreConnect.CiWorkflowRelationshipsMacOsVersion? MacOsVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildRuns")]
        public global::AppStoreConnect.CiWorkflowRelationshipsBuildRuns? BuildRuns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiWorkflowRelationships" /> class.
        /// </summary>
        /// <param name="product"></param>
        /// <param name="repository"></param>
        /// <param name="xcodeVersion"></param>
        /// <param name="macOsVersion"></param>
        /// <param name="buildRuns"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiWorkflowRelationships(
            global::AppStoreConnect.CiWorkflowRelationshipsProduct? product,
            global::AppStoreConnect.CiWorkflowRelationshipsRepository? repository,
            global::AppStoreConnect.CiWorkflowRelationshipsXcodeVersion? xcodeVersion,
            global::AppStoreConnect.CiWorkflowRelationshipsMacOsVersion? macOsVersion,
            global::AppStoreConnect.CiWorkflowRelationshipsBuildRuns? buildRuns)
        {
            this.Product = product;
            this.Repository = repository;
            this.XcodeVersion = xcodeVersion;
            this.MacOsVersion = macOsVersion;
            this.BuildRuns = buildRuns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiWorkflowRelationships" /> class.
        /// </summary>
        public CiWorkflowRelationships()
        {
        }

    }
}