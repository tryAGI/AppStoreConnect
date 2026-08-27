
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppStoreVersionExperimentTreatmentLocalizationRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersionExperimentTreatment")]
        public global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatment? AppStoreVersionExperimentTreatment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appScreenshotSets")]
        public global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSets? AppScreenshotSets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appPreviewSets")]
        public global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSets? AppPreviewSets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionExperimentTreatmentLocalizationRelationships" /> class.
        /// </summary>
        /// <param name="appStoreVersionExperimentTreatment"></param>
        /// <param name="appScreenshotSets"></param>
        /// <param name="appPreviewSets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppStoreVersionExperimentTreatmentLocalizationRelationships(
            global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatment? appStoreVersionExperimentTreatment,
            global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSets? appScreenshotSets,
            global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSets? appPreviewSets)
        {
            this.AppStoreVersionExperimentTreatment = appStoreVersionExperimentTreatment;
            this.AppScreenshotSets = appScreenshotSets;
            this.AppPreviewSets = appPreviewSets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionExperimentTreatmentLocalizationRelationships" /> class.
        /// </summary>
        public AppStoreVersionExperimentTreatmentLocalizationRelationships()
        {
        }

    }
}