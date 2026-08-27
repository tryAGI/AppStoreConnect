
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppPreviewSetRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersionLocalization")]
        public global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionLocalization? AppStoreVersionLocalization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appCustomProductPageLocalization")]
        public global::AppStoreConnect.AppPreviewSetRelationshipsAppCustomProductPageLocalization? AppCustomProductPageLocalization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersionExperimentTreatmentLocalization")]
        public global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalization? AppStoreVersionExperimentTreatmentLocalization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appPreviews")]
        public global::AppStoreConnect.AppPreviewSetRelationshipsAppPreviews? AppPreviews { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPreviewSetRelationships" /> class.
        /// </summary>
        /// <param name="appStoreVersionLocalization"></param>
        /// <param name="appCustomProductPageLocalization"></param>
        /// <param name="appStoreVersionExperimentTreatmentLocalization"></param>
        /// <param name="appPreviews"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppPreviewSetRelationships(
            global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionLocalization? appStoreVersionLocalization,
            global::AppStoreConnect.AppPreviewSetRelationshipsAppCustomProductPageLocalization? appCustomProductPageLocalization,
            global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalization? appStoreVersionExperimentTreatmentLocalization,
            global::AppStoreConnect.AppPreviewSetRelationshipsAppPreviews? appPreviews)
        {
            this.AppStoreVersionLocalization = appStoreVersionLocalization;
            this.AppCustomProductPageLocalization = appCustomProductPageLocalization;
            this.AppStoreVersionExperimentTreatmentLocalization = appStoreVersionExperimentTreatmentLocalization;
            this.AppPreviews = appPreviews;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPreviewSetRelationships" /> class.
        /// </summary>
        public AppPreviewSetRelationships()
        {
        }

    }
}