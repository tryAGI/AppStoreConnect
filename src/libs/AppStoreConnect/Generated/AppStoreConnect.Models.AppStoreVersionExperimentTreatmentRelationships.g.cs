
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppStoreVersionExperimentTreatmentRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersionExperiment")]
        public global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperiment? AppStoreVersionExperiment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersionExperimentV2")]
        public global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2? AppStoreVersionExperimentV2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersionExperimentTreatmentLocalizations")]
        public global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizations? AppStoreVersionExperimentTreatmentLocalizations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionExperimentTreatmentRelationships" /> class.
        /// </summary>
        /// <param name="appStoreVersionExperiment"></param>
        /// <param name="appStoreVersionExperimentV2"></param>
        /// <param name="appStoreVersionExperimentTreatmentLocalizations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppStoreVersionExperimentTreatmentRelationships(
            global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperiment? appStoreVersionExperiment,
            global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2? appStoreVersionExperimentV2,
            global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizations? appStoreVersionExperimentTreatmentLocalizations)
        {
            this.AppStoreVersionExperiment = appStoreVersionExperiment;
            this.AppStoreVersionExperimentV2 = appStoreVersionExperimentV2;
            this.AppStoreVersionExperimentTreatmentLocalizations = appStoreVersionExperimentTreatmentLocalizations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionExperimentTreatmentRelationships" /> class.
        /// </summary>
        public AppStoreVersionExperimentTreatmentRelationships()
        {
        }

    }
}