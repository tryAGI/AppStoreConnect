
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppPreviewSetCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersionLocalization")]
        public global::AppStoreConnect.AppPreviewSetCreateRequestDataRelationshipsAppStoreVersionLocalization? AppStoreVersionLocalization { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appCustomProductPageLocalization")]
        public global::AppStoreConnect.AppPreviewSetCreateRequestDataRelationshipsAppCustomProductPageLocalization? AppCustomProductPageLocalization { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersionExperimentTreatmentLocalization")]
        public global::AppStoreConnect.AppPreviewSetCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalization? AppStoreVersionExperimentTreatmentLocalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPreviewSetCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="appStoreVersionLocalization"></param>
        /// <param name="appCustomProductPageLocalization"></param>
        /// <param name="appStoreVersionExperimentTreatmentLocalization"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppPreviewSetCreateRequestDataRelationships(
            global::AppStoreConnect.AppPreviewSetCreateRequestDataRelationshipsAppStoreVersionLocalization? appStoreVersionLocalization,
            global::AppStoreConnect.AppPreviewSetCreateRequestDataRelationshipsAppCustomProductPageLocalization? appCustomProductPageLocalization,
            global::AppStoreConnect.AppPreviewSetCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalization? appStoreVersionExperimentTreatmentLocalization)
        {
            this.AppStoreVersionLocalization = appStoreVersionLocalization;
            this.AppCustomProductPageLocalization = appCustomProductPageLocalization;
            this.AppStoreVersionExperimentTreatmentLocalization = appStoreVersionExperimentTreatmentLocalization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPreviewSetCreateRequestDataRelationships" /> class.
        /// </summary>
        public AppPreviewSetCreateRequestDataRelationships()
        {
        }

    }
}