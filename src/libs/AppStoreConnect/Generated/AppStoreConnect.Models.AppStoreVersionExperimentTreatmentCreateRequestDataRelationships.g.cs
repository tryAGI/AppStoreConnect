
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppStoreVersionExperimentTreatmentCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersionExperiment")]
        public global::AppStoreConnect.AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperiment? AppStoreVersionExperiment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersionExperimentV2")]
        public global::AppStoreConnect.AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentV2? AppStoreVersionExperimentV2 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionExperimentTreatmentCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="appStoreVersionExperiment"></param>
        /// <param name="appStoreVersionExperimentV2"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppStoreVersionExperimentTreatmentCreateRequestDataRelationships(
            global::AppStoreConnect.AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperiment? appStoreVersionExperiment,
            global::AppStoreConnect.AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentV2? appStoreVersionExperimentV2)
        {
            this.AppStoreVersionExperiment = appStoreVersionExperiment;
            this.AppStoreVersionExperimentV2 = appStoreVersionExperimentV2;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionExperimentTreatmentCreateRequestDataRelationships" /> class.
        /// </summary>
        public AppStoreVersionExperimentTreatmentCreateRequestDataRelationships()
        {
        }

    }
}