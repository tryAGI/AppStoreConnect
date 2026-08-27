
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppStoreVersionExperimentV2Relationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        public global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsApp? App { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latestControlVersion")]
        public global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsLatestControlVersion? LatestControlVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controlVersions")]
        public global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsControlVersions? ControlVersions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersionExperimentTreatments")]
        public global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatments? AppStoreVersionExperimentTreatments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionExperimentV2Relationships" /> class.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="latestControlVersion"></param>
        /// <param name="controlVersions"></param>
        /// <param name="appStoreVersionExperimentTreatments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppStoreVersionExperimentV2Relationships(
            global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsApp? app,
            global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsLatestControlVersion? latestControlVersion,
            global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsControlVersions? controlVersions,
            global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatments? appStoreVersionExperimentTreatments)
        {
            this.App = app;
            this.LatestControlVersion = latestControlVersion;
            this.ControlVersions = controlVersions;
            this.AppStoreVersionExperimentTreatments = appStoreVersionExperimentTreatments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionExperimentV2Relationships" /> class.
        /// </summary>
        public AppStoreVersionExperimentV2Relationships()
        {
        }

    }
}