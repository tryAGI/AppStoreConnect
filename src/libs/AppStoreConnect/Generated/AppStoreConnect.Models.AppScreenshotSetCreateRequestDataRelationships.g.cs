
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppScreenshotSetCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersionLocalization")]
        public global::AppStoreConnect.AppScreenshotSetCreateRequestDataRelationshipsAppStoreVersionLocalization? AppStoreVersionLocalization { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appCustomProductPageLocalization")]
        public global::AppStoreConnect.AppScreenshotSetCreateRequestDataRelationshipsAppCustomProductPageLocalization? AppCustomProductPageLocalization { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersionExperimentTreatmentLocalization")]
        public global::AppStoreConnect.AppScreenshotSetCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalization? AppStoreVersionExperimentTreatmentLocalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppScreenshotSetCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="appStoreVersionLocalization"></param>
        /// <param name="appCustomProductPageLocalization"></param>
        /// <param name="appStoreVersionExperimentTreatmentLocalization"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppScreenshotSetCreateRequestDataRelationships(
            global::AppStoreConnect.AppScreenshotSetCreateRequestDataRelationshipsAppStoreVersionLocalization? appStoreVersionLocalization,
            global::AppStoreConnect.AppScreenshotSetCreateRequestDataRelationshipsAppCustomProductPageLocalization? appCustomProductPageLocalization,
            global::AppStoreConnect.AppScreenshotSetCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalization? appStoreVersionExperimentTreatmentLocalization)
        {
            this.AppStoreVersionLocalization = appStoreVersionLocalization;
            this.AppCustomProductPageLocalization = appCustomProductPageLocalization;
            this.AppStoreVersionExperimentTreatmentLocalization = appStoreVersionExperimentTreatmentLocalization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppScreenshotSetCreateRequestDataRelationships" /> class.
        /// </summary>
        public AppScreenshotSetCreateRequestDataRelationships()
        {
        }

    }
}